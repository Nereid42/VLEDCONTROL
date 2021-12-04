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
            Tools.InstallDcsScripts(dialog.BasePath);
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

            // ======== Create Engine ========
            CreateEngine();

            // ======== Setup ========
            // Add all missing files, if nessessary
            EnvironmentSetup();

            // ======== Creating Main Window ======== 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VLED.MainWindow = new MainWindowForm();
            // hanlde closing of window gracefully
            VLED.MainWindow.FormClosing += VLED.WindowClosing;

            // ======== Starting Main Engine ======== 
            VLED.Engine.SetUiController(VLED.MainWindow.Controller);
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
