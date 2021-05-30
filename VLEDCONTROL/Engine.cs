/*
 * MIT License

Copyright (c) 2021 Nereid

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace VLEDCONTROL
{
   public class Engine : Loggable
   {
      private const int UDP_PORT_RECEIVE = 5555;
      private const int UDP_PORT_SEND = 5556;
      public const int VALUE_COUNT = 1000;

      public readonly Settings CurrentSettings = new Settings();

      public Profile CurrentProfile = new Profile();

      private volatile bool StopRequest;
      private readonly Receiver Receiver;
      private readonly Sender Sender;

      private UiController Controller;
      private volatile bool ControlerInitDone;

      internal void Join(int timeoutInSeconds)
      {
         int timeInSeconds = 0;
         while(IsRunning && timeInSeconds < timeoutInSeconds)
         {
            for(int i=0; i<10 && IsRunning;i++)
            {
               Thread.Sleep(100);
            }
            timeInSeconds++;
         }
      }

      private volatile String CurrentAircraft;
      private volatile double[] CurrentProperties = new double[VALUE_COUNT];
      private volatile DateTime[] CurrentTimestamps = new DateTime[VALUE_COUNT];

      // Measuring time for performance analysis
      private Stopwatch swTotalRunning = new Stopwatch();
      private Stopwatch swCalcLeds = new Stopwatch();
      private Stopwatch swExecutes = new Stopwatch();

      private long Cycle = 0;

      private long Executes = 0;

      public volatile bool IsRunning = false;

      public Engine()
      {
         this.Sender = new Sender(UDP_PORT_SEND);
         this.Receiver = new Receiver(UDP_PORT_RECEIVE);
         Receiver.AddDataHandler(new EstablishCommunicationDataHandler(this));
         Receiver.AddDataHandler(new AircraftDataHandler(this));
         Receiver.AddDataHandler(new PropertyDataHandler(this));

         try
         {
            CurrentSettings.Load();
            CurrentProfile = Profile.Load(CurrentSettings.DefaultProfile);
            CurrentProfile.SaveAs("Backup.profile");
         }
         catch(Exception e)
         {
            LogException(e);
         }

         // data
         this.CurrentAircraft = null;

         ClearProperties();

      }

      private void ClearProperties()
      {
         for (int i = 0; i < VALUE_COUNT; i++)
         {
            CurrentProperties[i] = 0.0;
            CurrentTimestamps[i] = DateTime.MinValue;
         }
      }

      private void InitUiController()
      {
         if( Controller!=null && Controller.IsHandleCreated() )
         {
            LogInfo("Init data shown in UI");
            Controller.Clear();
            Controller.SetAircraftName(CurrentAircraft);
            Controller.SetSettings(CurrentSettings);
            Controller.SetProfileFilter(CurrentProfile);
            Controller.SetProfile(CurrentProfile);
            ControlerInitDone = true;
         }
         else
         {
            LogTrace("UI not ready. Init delayed");
         }
      }

      public void SetUiController(UiController controller)
      {
         this.Controller = controller;
         ControlerInitDone = false;
         InitUiController();
      }

      public void Start()
      {
         if(IsRunning)
         {
            LogWarning("Engine is still runing.");
         }
         this.StopRequest = false;
         Thread t = new Thread(new ThreadStart(this.Run));
         t.IsBackground = true;
         LogInfo("Starting engine thread");
         t.Start();
      }

      private void SendCommand(String command, String data)
      {
         if(data==null)
         {
            LogDebug("Sending command "+command);
            Sender.Send(command);
         }
         else
         {
            LogDebug("Sending command " + command+":"+data);
            Sender.Send(command+":"+data);
         }
      }

      private void SendCommand(String command)
      {
         SendCommand(command, null);
      }

      internal void Query()
      {
         LogInfo("Sending Query to DCS");
         SendCommand("QUERY");
      }

      internal void CommitDataUpdate()
      {
         SendCommand("INTERVAL:"+ Tools.ToString(CurrentSettings.DataInterval));
      }

      public void Stop()
      {
         LogInfo("Stoprequest for Engine");
         this.StopRequest = true;
      }

      public void RemoveDevice(VirpilDevice device)
      {
         // TODO
      }

      public void RemoveDevice(int deviceId)
      {
         if(deviceId < CurrentSettings.Devices.Count)
         {
            CurrentSettings.Devices.RemoveAt(deviceId);
         }
         else
         {
            LogError("device id " + deviceId + " not found");
         }
      }

      internal void SetAirplane(String aircraft)
      {
         this.CurrentAircraft = aircraft;
         LogDebug("airplane is now" + aircraft);
         //
         if (Controller!=null)
         {
            Controller.SetAircraftName(aircraft);
         }
      }

      internal void SetProperty(int id, double value)
      {
         CurrentProperties[id] = value;
         CurrentTimestamps[id] = DateTime.Now;

         if (Controller != null && CurrentSettings.LiveDataEnabled)
         {
            String name = CurrentProfile.MapPropertyName(CurrentAircraft, id);
            Controller.SetData(id, name, value, CurrentTimestamps[id]);
         }
      }

      internal void ShowProperties()
      {
         for(int id=0; id<CurrentProperties.Length; id++)
         {
            if(CurrentTimestamps[id] != null && CurrentTimestamps[id]!=DateTime.MinValue)
            {
               String name = CurrentProfile.MapPropertyName(CurrentAircraft, id);
               Controller.SetData(id, name, CurrentProperties[id], CurrentTimestamps[id]);
            }
         }
      }




      private void ExecuteLedCommand(VirpilDevice device, int ledNumber, LedColor color)
      {
         String command = CurrentSettings.VirpilLedControl;
         if(command==null || command.Length==0)
         {
            LogWarning("No Virpil LED Control path set");
            return;
         }

         String r = color.red.ToString("X2");
         String g = color.green.ToString("X2");
         String b = color.blue.ToString("X2");

         String arguments = device.USB_VID + " " + device.USB_PID + " " + ledNumber + " " + r + " " + g + " " + b;
         if(IsLoggable(LEVEL.TRACE)) LogTrace("EXECUTE COMMAND: "+ command+" "+ arguments);
         swExecutes.Start();
         Tools.ExecuteCommand(command, arguments);
         swExecutes.Stop();
         Interlocked.Increment(ref Executes);
      }


      private void SetAllDeviceLeds()
      {
         if (IsLoggable(LEVEL.DEBUG)) LogDebug("Set all device LEDs");
         foreach (VirpilDevice device in CurrentSettings.Devices)
         {
            if (IsLoggable(LEVEL.DEBUG)) LogDebug("Set LEDs for device " + device.Name);
            for (int ledNumber = device.MinLedNumber; ledNumber <= device.MaxLedNumber; ledNumber++)
            {
               LedColor color = device.SetCurrentColor(ledNumber);
               if (color != null)
               {
                  if(IsLoggable(LEVEL.DEBUG))
                  {
                     LogDebug("LED " + ledNumber + " is " + color);
                     LogTrace("Set color for led " + ledNumber + " on device " + device.Name + " to " + color);
                  }
                  ExecuteLedCommand(device, ledNumber, color);
               }
            }
         }
      }

      private void CalculateLEDs()
      {
         swCalcLeds.Start();

         if (IsLoggable(LEVEL.DEBUG)) LogDebug("calculating all LEDs");

         foreach (Profile.ProfileEvent entry in CurrentProfile.ProfileEvents)
         {
            if (IsLoggable(LEVEL.DEBUG)) LogDebug("calculating LED for "+entry);
            if(CurrentAircraft == entry.Aircraft)
            {
               int id = entry.Id;
               double currentValue = CurrentProperties[id];
               double primaryValue = entry.PrimaryValue;
               double secondaryValue = entry.SecondaryValue;
               if ( CheckCondition(currentValue, primaryValue, entry.PrimaryCondition) 
               && ( CheckCondition(currentValue, secondaryValue, entry.SecondaryCondition)) )
               {
                  if (IsLoggable(LEVEL.DEBUG)) LogDebug("-> Condition true");
                  VirpilDevice device = CurrentSettings.GetDevice(entry.DeviceId);
                  if (device != null)
                  {
                     if(IsFlashCycle())
                     {
                        if (IsLoggable(LEVEL.DEBUG)) LogDebug("-> LED Color FLASH " + entry.ColorFlashing);
                        device.PrepareColor(entry.LedNumber, entry.ColorFlashing);
                     }
                     else
                     {
                        if (IsLoggable(LEVEL.DEBUG)) LogDebug("-> LED Color ON " + entry.ColorOn);
                        device.PrepareColor(entry.LedNumber, entry.ColorOn);
                     }
                  }
               }
            }
         }
         SetAllDeviceLeds();

         swCalcLeds.Stop();
      }

      private void ResetAllDeviceLeds()
      {
         foreach(VirpilDevice device in CurrentSettings.Devices)
         {
            ExecuteLedCommand(device,0, LedColor.BLACK);
         }
      }

      private bool CheckCondition(double currentValue, double value, string condition)
      {
         if (IsLoggable(LEVEL.DEBUG)) LogDebug("Check condition: "+currentValue + condition +value);
         switch(condition)
         {
            case "":   return true;
            case "S":  return true;
            case "=":  return currentValue == value;
            case "!=": return currentValue != value;
            case "<>": return currentValue != value;
            case "<=": return currentValue <= value;
            case ">=": return currentValue >= value;
            case "<":  return currentValue <  value;
            case ">":  return currentValue >  value;
            case "NONE": return true;
            case "-": return true;
            default:
               LogError("Invalid condition: '"+condition);
               return false;
         }
      }

      private bool IsFlashCycle()
      {
         return (Cycle / CurrentSettings.FlashingCycles) % 2 != 0;
      }

      private void Run()
      {
         swTotalRunning.Start();

         LogInfo("starting engine...");
         IsRunning = true;

         if (Controller != null)
         {
            Controller.SetEngineStarted(true);
         }

         // Setup Communication
         Receiver.Start();
         Query();


         long millis = -1000;
         while (!this.StopRequest)
         {
            try
            {
               if (IsLoggable(LEVEL.TRACE)) LogTrace("main loop cycle " + Cycle);

               // Update UI
               if (Controller != null)
               {
                  if (!ControlerInitDone)
                  {
                     // First Init
                     InitUiController();
                  }
                  //
                  // Live Statistics enabled?
                  if(CurrentSettings.StatisticsEnabled)
                  {
                     // Update Statistics every second
                     if (swTotalRunning.ElapsedMilliseconds >= millis + 1000)
                     {
                        millis = swTotalRunning.ElapsedMilliseconds;
                        Controller.DisplayStatistics(swTotalRunning.ElapsedMilliseconds, swCalcLeds.ElapsedMilliseconds, Executes);
                     }
                  }     
               }

               CalculateLEDs();
               if (IsLoggable(LEVEL.DEBUG)) LogDebug("Commdands executed: " + Executes);

               Thread.Sleep(CurrentSettings.GetUpdateIntervalInMillis());
            }
            catch (Exception e)
            {
               LogException(e);
            }
            finally
            {
               Cycle++;
            }
         }

         Receiver.Stop();
         // Wait until Receiver is terminated
         Receiver.Join();
         // Reset Devices
         ResetAllDeviceLeds();

         if (Controller != null)
         {
            Controller.SetEngineStarted(false);
         }

         IsRunning = false;
         LogInfo("engine stopped");

         LogInfo("Total time running: "+swTotalRunning.ElapsedMilliseconds+" ms");
         LogInfo("Calculating Leds: " + swCalcLeds.ElapsedMilliseconds + " ms");
         LogInfo("Executes: " + swCalcLeds.ElapsedMilliseconds + " ms for "+Executes+" command executes");

         swTotalRunning.Stop();
      }


   }
}
