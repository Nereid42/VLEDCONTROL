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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace VLEDCONTROL
{
   class VLED : Loggable
   {
      static public String Version;

      static public MainWindowForm MainWindow;
      static public Engine Engine;

      static public volatile bool IsFirstRun = false;

      static public void Exit()
      {
         LogInfo("exiting VLED...");
         Engine.Stop();
         Engine.CurrentSettings.Save();
         Engine.Join(10);
         Environment.Exit(0);
      }

      private static void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
      {
         LogDebug("Window closing event detected");
         e.Cancel = true;
         Exit();
      }

      private static void LoadVersion()
      {
         try
         {
            Version = System.IO.File.ReadAllText("version");
         }
         catch
         {
            Version = "unknown";
         }
      }

      private static void EnvironmentSetup()
      {
         // Create Settings if not present
         Settings defaultSettings = new Settings();
         if ( ! Settings.FileExists() )
         {
            IsFirstRun = true;
            defaultSettings.Save();
            Engine.CurrentSettings.Load();
            Engine.CurrentProfile = Profile.Load(defaultSettings.DefaultProfile);
         }
         // Create Empty Default-Profile if not present
         Engine.CurrentSettings.Load();
         if (!System.IO.File.Exists(defaultSettings.DefaultProfile))
         {
            Profile profile = new Profile();
            profile.Name = "Default";
            profile.SaveAs(defaultSettings.DefaultProfile);
            Engine.CurrentProfile = profile;
         }
      }

      public static void ShowInstallScriptsDialog(bool isFirstInstallation)
      {
         InstallScriptsDialog dialog = new InstallScriptsDialog();
         if(isFirstInstallation)
         {
            dialog.textBoxFirstInstallWarning.ForeColor = System.Drawing.Color.Red;
            dialog.textBoxFirstInstallWarning.Visible = true;
         }
         if (dialog.ShowDialog() == DialogResult.OK)
         {
            Tools.CopyDcsScripts(dialog.BasePath);
         }
      }

      public static void ShowVpcLedControlSetupDialog()
      {
         VpcLedControlSetupDialog dialog = new VpcLedControlSetupDialog();
         while (VLED.Engine.CurrentSettings.VirpilLedControl == null || VLED.Engine.CurrentSettings.VirpilLedControl.Length == 0)
         {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               VLED.Engine.CurrentSettings.VirpilLedControl = dialog.VpcLedControlExePath;
               VLED.Engine.CurrentSettings.SaveAsync();
               VLED.MainWindow.Controller.SetSettings(VLED.Engine.CurrentSettings);
            }
            if(VLED.Engine.CurrentSettings.VirpilLedControl == null || VLED.Engine.CurrentSettings.VirpilLedControl.Length == 0)
            {
               switch (MessageBox.Show("VPC_LED_COntrol.exe not found", "Setup incomplete", MessageBoxButtons.AbortRetryIgnore))
               {
                  case DialogResult.Abort:
                     VLED.Exit();
                     break;
                  case DialogResult.Ignore:
                     return;
               }
            }
         }
      }


      /// <summary>
      /// Main Entry Point
      /// </summary>
      [STAThread]
      static void Main()
      {
         // ======== Load Version ========
         LoadVersion();

         // ======== create Engine ========
         try
         {
            VLED.Engine = new Engine();
         }
         catch(System.Net.Sockets.SocketException)
         {
            Tools.ShowErrorDialog("Failed to start engine. Socket already in use. Is VLEDCONTROL already running?");
         }
         catch (Exception e)
         {
            Loggable.LogException("Failed to start engine",e);
            Tools.ShowExceptionDialog(e);
            Exit();
         }    

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
         LogInfo("Opening main window");
         Application.Run(VLED.MainWindow);
      }


      public static void DEBUG(String msg)
      {
         Loggable.LogUrgend(msg);
      }
   }


}
