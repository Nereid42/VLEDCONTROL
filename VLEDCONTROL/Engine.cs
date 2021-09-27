/* written 2021 by Nereid
  
 Apache 2.0 License
 (see LICENSE file)

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

      // Data
      private volatile String CurrentAircraft;
      private volatile double[] CurrentProperties = new double[VALUE_COUNT];
      private volatile DateTime[] CurrentTimestamps = new DateTime[VALUE_COUNT];

      // Measuring time for performance analysis
      private Stopwatch swTotalRunning = new Stopwatch();
      private Stopwatch swCalcLeds = new Stopwatch();
      private Stopwatch swExecutes = new Stopwatch();

      // Highlight single LED
      private long HightlightEndCycle = 0;
      private volatile int HightlightLedNr = -1;
      private volatile int HighlightDeviceID = -1;
      private LedColor HighlightColor = null;

      private long Cycle = 0;

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

      internal void Join(int timeoutInSeconds)
      {
         LogDebug("Waiting for engine to stop...");
         int timeInSeconds = 0;
         while (IsRunning && timeInSeconds < timeoutInSeconds)
         {
            for (int i = 0; i < 10 && IsRunning; i++)
            {
               if (IsLoggable(LEVEL.TRACE)) LogTrace("Sleeping (waiting for engine to stop)...");
               Thread.Sleep(100);
            }
            timeInSeconds++;
         }
         LogDebug("Engine is stopped");
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
            if(IsLoggable(LEVEL.TRACE)) LogTrace("UI not ready. Init delayed");
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
         LogDebug("Starting engine thread");
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
         LogDebug("Stoprequest for Engine");
         this.StopRequest = true;
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
         if(Controller!=null)
         {
            for (int id = 0; id < CurrentProperties.Length; id++)
            {
               if (CurrentTimestamps[id] != null && CurrentTimestamps[id] != DateTime.MinValue)
               {
                  String name = CurrentProfile.MapPropertyName(CurrentAircraft, id);
                  Controller.SetData(id, name, CurrentProperties[id], CurrentTimestamps[id]);
               }
            }
            Controller.MarkDataAsDirty(false);
         }
      }

      private void SetAllDeviceLeds()
      {
         if (IsLoggable(LEVEL.DEBUG)) LogDebug("Set all device LEDs");
         for(int deviceId =0; deviceId < CurrentSettings.Devices.Count; deviceId++)
         {
            VirpilDevice device = CurrentSettings.Devices[deviceId];
            //
            if (IsLoggable(LEVEL.DEBUG)) LogDebug("Set LEDs for device " + device.Name);
            //
            for (int ledNumber = device.MinLedNumber; ledNumber <= device.MaxLedNumber; ledNumber++)
            {
               // is led highlighted?
               if (ledNumber == this.HightlightLedNr && deviceId == this.HighlightDeviceID)
               {
                  if(HightlightEndCycle > Cycle)
                  {
                     device.PrepareColor(ledNumber, HighlightColor);
                  }
                  else
                  {
                     device.PrepareColor(ledNumber, LedColor.BLACK);
                     this.HightlightLedNr = -1;
                     this.HighlightDeviceID = -1;
                  }
               }
               //
               LedColor color = device.SetCurrentColor(ledNumber);
               if (color != null)
               {
                  if (IsLoggable(LEVEL.DEBUG))
                  {
                     LogDebug("LED " + ledNumber + " is " + color);
                     LogTrace("Set color for led " + ledNumber + " on device " + device.Name + " to " + color);
                  }
                  device.SendCommand(ledNumber, color);
               }
            }
         }
      }

      public void HighlightLed(int deviceId, int lednumber, LedColor color)
      {
         Interlocked.Exchange( ref this.HightlightEndCycle ,Interlocked.Read(ref Cycle) + CurrentSettings.FlashingCycles);
         HighlightDeviceID = deviceId;
         HightlightLedNr = lednumber;
         HighlightColor = color;
      }

      public void CalculateLEDs()
      {
         lock(CurrentSettings)
         {
            swCalcLeds.Start();

            if (IsLoggable(LEVEL.DEBUG)) LogDebug("calculating all LEDs");

            foreach (Profile.ProfileEvent entry in CurrentProfile.ProfileEvents)
            {
               if (IsLoggable(LEVEL.DEBUG)) LogDebug("calculating LED for " + entry);
               if (CurrentAircraft == entry.Aircraft)
               {
                  int id = entry.Id;
                  double currentValue = CurrentProperties[id];
                  double primaryValue = entry.PrimaryValue;
                  double secondaryValue = entry.SecondaryValue;
                  if (CheckCondition(currentValue, primaryValue, entry.PrimaryCondition)
                  && (CheckCondition(currentValue, secondaryValue, entry.SecondaryCondition)))
                  {
                     if (IsLoggable(LEVEL.DEBUG)) LogDebug("-> Condition true");
                     VirpilDevice device = CurrentSettings.GetDevice(entry.DeviceId);
                     if (device != null)
                     {
                        if (IsFlashCycle())
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
      }

      public void ResetAllDeviceLeds()
      {
         foreach(VirpilDevice device in CurrentSettings.Devices)
         {
            if (IsLoggable(LEVEL.DEBUG)) LogDebug("Init device " + device.Name);
            device.Reset();
            device.SendResetCommand();
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

               // Check if receiver is running
               if(!Receiver.IsRunning)
               {
                  LogError("Receiver is not running anymore! Enigne stopped.");
                  break;
               }

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
                        Controller.DisplayStatistics(swTotalRunning.ElapsedMilliseconds, swCalcLeds.ElapsedMilliseconds, VirpilDevice.UsbCommandCnt);
                     }
                  } 
                  // Is displayed data dirty?
                  if(Controller.IsDataDirty)
                  {
                     // data is dirty, sending all properties to Controller if live data is enabled
                     if (CurrentSettings.LiveDataEnabled)
                     {
                        ShowProperties();
                     }
                  }
               }

               CalculateLEDs();
               if (IsLoggable(LEVEL.DEBUG)) LogDebug("USB command send: " + VirpilDevice.UsbCommandCnt);

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
         LogInfo("Engine stopped");

         LogInfo("Total time running: "+swTotalRunning.ElapsedMilliseconds+" ms");
         LogInfo("Calculating Leds: " + swCalcLeds.ElapsedMilliseconds + " ms");
         LogInfo("Executes: " + swCalcLeds.ElapsedMilliseconds + " ms for "+ VirpilDevice.UsbCommandCnt + " command executes");

         swTotalRunning.Stop();
      }

      internal void Connect()
      {
         LogInfo("Connection to DCS");
         if (Controller != null)
         {
            Controller.ClearData();
         }

         ResetAllDeviceLeds();

         ResetAllProperties();

         CommitDataUpdate();
      }

      private void ResetAllProperties()
      {
         for(int i=0; i<CurrentProperties.Length; i++)
         {
            CurrentProperties[i] = 0.0;
            CurrentTimestamps[i] = DateTime.MinValue;
         }
      }
   }
}
