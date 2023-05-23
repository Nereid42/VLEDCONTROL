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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Linq.Expressions;

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
         System.Diagnostics.Process process = System.Diagnostics.Process.GetCurrentProcess();
         LogInfo("exiting VLED (process id " + process.Id + ")... ");
         Engine.Stop();
         Engine.CurrentSettings.Save();
         Engine.Join(10);
         if(Application.MessageLoop)
         {
            LogInfo("Calling Application.Exit()");
            Application.Exit();
         }
         LogInfo("Calling Environment.Exit(0)");
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
            Version = Version.TrimEnd('\r', '\n', ' ');
            Loggable.LogInfo("Version loaded: '"+Version+"'");
         }
         catch
         {
            Version = "unknown";
         }
      }

      private static void EnvironmentSetup()
      {
         Loggable.LogInfo("setting up environment...");

         // Create Settings if not present
         Settings defaultSettings = new Settings();
         if ( ! Settings.FileExists() )
         {
            IsFirstRun = true;

            if (!System.IO.File.Exists(defaultSettings.DefaultProfile))
            {
               Profile profile = new Profile();
               profile.Name = "Default";
               profile.SaveAs(defaultSettings.DefaultProfile);
               //Engine.CurrentProfile = profile;
            }

            defaultSettings.Save();
         }

         // check version of last execution
         string lastVersionFile = "last.version";
         string lastVersion = Tools.ReadFirstLineFromFile(lastVersionFile);
         Loggable.LogInfo("last executed version was '" + Version + "'");
         // Comparer versions without build numbers
         string cmpCurrentVersion = Tools.SafeSplit(Version, '-')[0] ;
         string cmpLastVersion = Tools.SafeSplit(lastVersion, '-')[0] ;
         if (!cmpLastVersion.Equals(cmpCurrentVersion) )
         {
            Loggable.LogInfo("not recent last executed version, forcing setup of hooks");
            IsFirstRun = true;
            Loggable.LogInfo("writing version '" + Version + "' to file '"+lastVersionFile+"'");
            Tools.WriteLineToFile(lastVersionFile, Version);
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
            try
            {
               Tools.InstallDcsScripts(dialog.BasePath);
            }
            catch
            {
               Tools.ShowErrorDialog("Failed to install export scripts!");
            }
         }
      }


      private static void InitLogging()
      {
         // ======== Init Logging ======== 
         Settings settings = new Settings();
         try
         {
            settings.Load();
            SetLogLevel(settings.LogLevel);
         } 
         catch(System.IO.FileNotFoundException)
         {
            SetLogLevel(LEVEL.INFO);
            LogWarning("Could not find ini file.");
         }
      }


      private static void DebugSetup()
      {
         if(System.IO.File.Exists("debug"))
         {
            Loggable.LogUrgend("debug enabled");
            Engine.CurrentSettings._DebugEnabled = true;
         }
      }

      private static void CreateEngine()
      {
         LogInfo("Creating engine");

         // Log Process data
         System.Diagnostics.Process process = System.Diagnostics.Process.GetCurrentProcess();
         LogInfo("Process id: " + process.Id);

         // ======== create Engine ========
         try
         {
            VLED.Engine = new Engine();
         }
         catch (System.Net.Sockets.SocketException)
         {
            Tools.ShowErrorDialog("Failed to start engine. Socket already in use. Is VLEDCONTROL already running?");
         }
         catch (Exception e)
         {
            Loggable.LogException("Failed to start engine", e);
            Tools.ShowExceptionDialog(e);
            Exit();
         }
      }

      /// <summary>
      /// Main Entry Point
      /// </summary>
      [STAThread]
      static void Main()
      {
         try
         {
            // ======== Init Logging ========
            InitLogging();

            // ======== Load Version ========
            LoadVersion();

            // ======== Setup ========
            // Add all missing files, if nessessary
            EnvironmentSetup();

            // ======== Create Engine ========
            CreateEngine();
            // check for debug
            DebugSetup();

            // ======== Creating Main Window ======== 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VLED.MainWindow = new MainWindowForm();
            // enable debug menu
            if (Engine.CurrentSettings._DebugEnabled) VLED.MainWindow.debugToolStripMenuItem.Visible = true;
            // hanlde closing of window gracefully
            VLED.MainWindow.FormClosing += VLED.WindowClosing;

            // ======== Starting Main Engine ======== 
            if(VLED.Engine.CurrentSettings.AutostartEnabled)
            {
               LogInfo("Starting engine");
               VLED.Engine.Start();
            }

            // ======== Show Main Window ======== 
            LogInfo("Opening main window");
            Application.Run(VLED.MainWindow);
         }
         catch(Exception e)
         {
            LogException(e);
         }

      }

   }


}
