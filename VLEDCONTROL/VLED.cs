using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace VLEDCONTROL
{
   class VLED : Loggable
   {
      static public MainWindowForm MainWindow;
      static public Engine Engine = new Engine();

      static public void Exit()
      {
         LogInfo("exiting VLED...");
         Engine.CurrentSettings.Save();
         Environment.Exit(0);
      }

      private static void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
      {
         e.Cancel = true;
         Exit();
      }

      private static void EnvironmentSetup()
      {
         // Create Settings if not present
         Settings defaultSettings = new Settings();
         if ( ! Settings.FileExists() )
         {
            defaultSettings.Save();
         }
         defaultSettings.Load();
         // Create Empty Default-Profile if not present
         if (!System.IO.File.Exists(defaultSettings.DefaultProfile))
         {
            Profile profile = new Profile();
            profile.Name = "Default";
            profile.SaveAs(defaultSettings.DefaultProfile);
         }
      }


      /// <summary>
      /// Main Entry Point
      /// </summary>
      [STAThread]
      static void Main()
      {
         // ======== Setup´========
         // Add all missing files, if nessessary
         EnvironmentSetup();

         // ======== Init Logging ======== 
         Settings settings = new Settings();
         settings.Load();
         SetLogLevel(settings.LogLevel);
         LogInfo("starting VLED");


         // ======== Creating Main Window ======== 
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         VLED.MainWindow = new MainWindowForm();
         // hanlde closing of window gracefully
         VLED.MainWindow.FormClosing += VLED.WindowClosing;

         // ======== Starting Main Engine ======== 
         VLED.Engine.SetUiController(VLED.MainWindow.Controller);
         VLED.Engine.Start();
         //

         // ======== Show Main Window ======== 
         Application.Run(VLED.MainWindow);
      }


      public static void DEBUG(String msg)
      {
         Loggable.LogError(msg);
      }
   }


}
