﻿using System;
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
      public const int VALUE_COUNT = 1000;

      public readonly Settings CurrentSettings = new Settings();

      public Profile CurrentProfile = new Profile();

      private volatile bool StopRequest;
      private Receiver Receiver;

      private UiController Controller;
      private volatile bool ControlerInitDone;

      private volatile String CurrentAircraft;
      private volatile double[] CurrentProperties = new double[VALUE_COUNT];
      private volatile DateTime[] CurrentTimestamps = new DateTime[VALUE_COUNT];

      private long Cycle = 0;

      private long Executes = 0;

      public volatile bool IsRunning = false;

      public Engine()
      {
         this.Receiver = new Receiver(5555);
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

         if (Controller != null)
         {
            String name = CurrentProfile.MapPropertyName(CurrentAircraft, id);
            Controller.SetData(id, name, value, CurrentTimestamps[id]);
         }
      }

      public void Stop()
      {
         LogInfo("Stoprequest for Engine");
         this.StopRequest = true;
      }



      private void ExecuteLedCommand(VirpilDevice device, int ledNumber, Color color)
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
         Tools.ExecuteCommand(command, arguments);
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
               Color color = device.SetCurrentColor(ledNumber);
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
         try
         {

            LogInfo("starting engine...");
            IsRunning = true;

            if (Controller != null)
            {
               Controller.SetEngineStarted(true);
            }

            Receiver.Start();

            while (!this.StopRequest)
            {
               if (IsLoggable(LEVEL.TRACE)) LogTrace("main loop cycle " + Cycle);

               if (!ControlerInitDone && Controller != null)
               {
                  InitUiController();
               }

               CalculateLEDs();
               if (IsLoggable(LEVEL.DEBUG)) LogDebug("Commdands executed: " + Executes);

               Thread.Sleep(CurrentSettings.GetUpdateIntervalInMillis());
               Cycle++;
            }

            Receiver.Stop();

            if (Controller != null)
            {
               Controller.SetEngineStarted(false);
            }

            IsRunning = false;
            LogInfo("engine stopped");
         }
         catch (Exception e)
         {
            LogException(e);
         }
      }


   }
}
