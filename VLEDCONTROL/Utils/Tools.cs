﻿/* written 2021 by Nereid
  
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
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Globalization;

namespace VLEDCONTROL
{
   public static class Tools 
   {
      private static readonly System.Globalization.CultureInfo EN_CI = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

      private const String EXPORTFILE_NAME = "/Scripts/Export.lua";
      private const String EXPORTFILE_MARKER = "--[[VLEDCONTROL]]";
      private const String EXPORTFILE_VLED_CMD = "local Vledlfs=require('lfs');dofile(Vledlfs.writedir()..'Scripts/vled/VledExport.lua')";

      public static int ToInt(String s)
      {
         try
         {
            return int.Parse(s, CultureInfo.InvariantCulture);
         }
         catch
         {
            return 0;
         }
      }

      public static double ToDouble(String s)
      {
         try
         {
            return double.Parse(s, CultureInfo.InvariantCulture);
         }
         catch
         {
            return 0.0;
         }
      }

      public static float ToFloat(String s)
      {
         try
         {
            return float.Parse(s, CultureInfo.InvariantCulture);
         }
         catch
         {
            return 0.0f;
         }
      }

      public static string ToString(double value)
      {
         return String.Format(EN_CI, "{0:0.##}", value);
      }


      public static void NumericKeyPressed(Object o, KeyPressEventArgs e)
      {
         if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '.' || e.KeyChar == 8 || e.KeyChar == '-')
         {
            e.Handled = false;
            return;
         }
         e.Handled = true;
      }


      public static void IntegerKeyPressed(Object o, KeyPressEventArgs e)
      {
         if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
         {
            e.Handled = false;
            return;
         }
         e.Handled = true;
      }

      internal static string ScanForFile(string path,string file)
      {
         string[] files = Directory.GetFiles(path);
         foreach ( string cmp in files )
         {
            string name = Path.GetFileName(cmp);
            if (name.Equals(file))
            {
               return cmp;
            }
         }
         string[] dirs = Directory.GetDirectories(path);

         foreach (string dir in dirs)
         {
            try
            {
               string match = ScanForFile(dir, file);
               if (match != null) return match;
            }
            catch
            {
               // ignore all exceptions
            }
         }
         return null;
      }

      internal static String AlphaNumeric(String text)
      {
         StringBuilder result = new StringBuilder();

         foreach(char c in text)
         {
            if( ( c >= 'a' && c <= 'z' )
            ||  ( c >= 'A' && c <= 'Z' )
            ||  ( c >= '0' && c <= '9' )
            ||  ( c == ' ' )
            ||  ( c == '_' ) )
            {
               result.Append(c);
            }
         }

         return result.ToString();
      }

      public static void NoKeyPressed(Object o, KeyPressEventArgs e)
      {
         e.Handled = true;
      }


      public static String GetApplicationFolder()
      {
         return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
      }

      internal static void MakeDir(string path)
      {
         if (!Directory.Exists(path))
         {
            Directory.CreateDirectory(path);
         }
      }

      internal static void DeleteScriptFile(string dcsBasePath,String filename)
      {
         String path = dcsBasePath + "/Scripts/" + filename;
         Loggable.LogInfo("deleting file '" + path + "'");
         if (System.IO.File.Exists(path))
         {
            try
            {
               System.IO.File.Delete(path);
            }
            catch
            {
               Loggable.LogWarning("failed to delete file '"+path+"'");
            }
         }
      }

      internal static void DeleteScriptFolder(string dcsBasePath, String foldername)
      {
         String path = dcsBasePath + "/Scripts/" + foldername;
         Loggable.LogInfo("deleting folder '"+ path + "'");
         if (System.IO.Directory.Exists(path))
         {
            try
            {
               System.IO.Directory.Delete(path);
            }
            catch
            {
               Loggable.LogWarning("failed to delete folder '" + path + "'");
            }
         }
      }


      internal static void RemoveObsoleteDcsScripts(string dcsBasePath)
      {
         DeleteScriptFile(dcsBasePath,"Hooks/VledExportHook.lua");
         DeleteScriptFile(dcsBasePath, "Hooks/vled/VledExport.lua");
         DeleteScriptFolder(dcsBasePath, "Hooks/vled");
      }

      internal static void InstallDcsExportScript(string dcsBasePath)
      {
         String exportfile = dcsBasePath + EXPORTFILE_NAME;
         if(!File.Exists(exportfile))
         {
            File.AppendAllText(exportfile, "-- created by VLEDCONTROL\n");
         }
         string[] lines = System.IO.File.ReadAllLines(exportfile);
         // check if VLED export is alöready called
         foreach (String line in lines)
         {
            if (line.StartsWith(EXPORTFILE_MARKER))
            {
               return;
            }
         }

         // add VLED axport at the beginning of the Export-script
         string tempFile = exportfile + ".new";

         using (var sr = new StreamReader(exportfile))
         using (var sw = new StreamWriter(tempFile))
         {
            string line;

            bool commandWritten = false;

            while ((line = sr.ReadLine()) != null)
            {
               if (line.Length>0 && !line.StartsWith("--") && !commandWritten)
               {
                  sw.WriteLine(EXPORTFILE_MARKER + " " + EXPORTFILE_VLED_CMD);
                  commandWritten = true;
               }
               sw.WriteLine(line);
            }
         }

         File.Delete(exportfile);
         File.Move(tempFile, exportfile);
      }

      internal static void UninstallDcsExportScript(string dcsBasePath)
      {
         String exportfile = dcsBasePath + EXPORTFILE_NAME;
         string tempFile = exportfile + ".new";

         using (var sr = new StreamReader(exportfile))
         using (var sw = new StreamWriter(tempFile))
         {
            string line;

            while ((line = sr.ReadLine()) != null)
            {
               if (!line.StartsWith(EXPORTFILE_MARKER))
                  sw.WriteLine(line);
            }
         }

         File.Delete(exportfile);
         File.Move(tempFile, exportfile);
      }

      internal static void InstallDcsScripts(string dcsBasePath)
      {
         try
         {
            Loggable.LogInfo("Installing DCS scripts");
            //
            MakeDir(dcsBasePath + "/Scripts");
            MakeDir(dcsBasePath + "/Scripts/vled");
            System.IO.File.Copy("Scripts/vled/VledExport.lua", dcsBasePath + "/Scripts/vled/VledExport.lua", true);
            //
            UninstallDcsExportScript(dcsBasePath);
            RemoveObsoleteDcsScripts(dcsBasePath);
            MakeDir(dcsBasePath + "/Scripts/Hooks");
            System.IO.File.Copy("Scripts/Hooks/VledExportHook.lua", dcsBasePath + "/Scripts/Hooks/VledExportHook.lua", true);
         }
         catch(Exception e)
         {
            Loggable.LogException("failed to uninstall export scripts", e);
            throw e;
         }
      }

      internal static void UninstallDcsScripts(string dcsBasePath)
      {
         try
         {
            RemoveObsoleteDcsScripts(dcsBasePath);
            DeleteScriptFile(dcsBasePath, "/vled/VledExport.lua");
            DeleteScriptFile(dcsBasePath, "/Hooks/VledExportHook.lua");
            DeleteScriptFolder(dcsBasePath, "/vled");
            UninstallDcsExportScript(dcsBasePath);
         }
         catch(Exception e)
         {
            Loggable.LogException("failed to uninstall export scripts",e);
            throw e;
         }
      }


      public static Process ExecuteCommand(string command, String arguments)
      {
         if (Loggable.IsLoggable(Loggable.LEVEL.DEBUG)) Loggable.LogDebug("EXECUTE: " + command + " " + arguments);

         if(!File.Exists(command))
         {
            Loggable.LogError("command not found: '"+command+"'");
            return null;
         }

         ProcessStartInfo ProcessInfo;

         ProcessInfo = new ProcessStartInfo(command, arguments);
         ProcessInfo.CreateNoWindow = true;
         ProcessInfo.UseShellExecute = true;

         return Process.Start(ProcessInfo);
      }


      public static bool IsInteger(String s)
      {
         try
         {
            int.Parse(s);
            return true;
         }
         catch
         {
            return false;
         }
      }

      public  static int IndexOfSelectedComboBoxItem(ComboBox box)
      {
         int result = -1;
         foreach (Object item in box.Items)
         {
            result++;
            if (item.Equals(box.Text)) return result;
         }
         return -1;
      }

      internal static void TrySelectComboBoxItem(ComboBox box, string text)
      {
         foreach (Object item in box.Items)
         {
            if (item.Equals(text))
            {
               box.Text = item.ToString();
               return;
            }
         }
         box.Text = "";
      }

      internal static String EnabledToYesNo(bool enabled)
      {
         return enabled ? "+":"-";
      }

      public static void SelectComboBoxItem(ComboBox box, int index)
      {
         if (index < box.Items.Count)
         {
            box.Text = box.Items[index].ToString();
         }
      }

      public static void ShowExceptionDialog(Exception e)
      {
         string message = e.GetType() + "\n\n" + e.Message;
         MessageBox.Show(message, "Exception!", MessageBoxButtons.OK);
      }

      internal static void ShowErrorDialog(string message)
      {
         Loggable.LogError(message);
         MessageBox.Show(message, "Error!", MessageBoxButtons.OK);
      }

      internal static double Distance(int x1, int y1, int x2, int y2)
      {
         return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
      }

      internal static int LedIndexToLednr(int index)
      {
         if (index < 4) return index;
         if (index < 25) return index - 4;
         return index-24;
      }

      public static System.Drawing.Color GetBestForegroundColor(System.Drawing.Color background)
      {
         int sum = background.R + background.G + background.B;
         if (sum<=256)
         {
            return System.Drawing.Color.LightGray;
         }
         return System.Drawing.Color.Black;
      }

      public static void Sleep(int millis)
      {
         System.Threading.Thread.Sleep(millis);
      }

      public static void CopyProfileMapping(Profile from, Profile to)
      {
         to.MappingEntries.Clear();
         to.ImportMapping(from);
      }

      public static string ReadFirstLineFromFile(string pathToFile)
      {
         try
         {
            using (StreamReader file = new StreamReader(pathToFile))
            {
               string line = file.ReadLine();
               if( line != null)
               {
                  return line.TrimEnd('\r', '\n', ' ');
               }
               return "";
            }
         }
         catch
         {
            Loggable.LogWarning("cannot read from file '" + pathToFile + "'");
            return "";
         }
      }

      public static void WriteLineToFile(string pathToFile, String line)
      {
         try
         {
            using (StreamWriter file = new StreamWriter(pathToFile))
            {
               file.WriteLine(line);
            }
         }
         catch
         {
            Loggable.LogWarning("cannot write to file '"+ pathToFile + "'");
         }
      }


      public static void CopyDefaultProfileMapping()
      {
         try
         {
            Profile defaultProfile = Profile.Load("default.profile");
            foreach(String profilename in Directory.GetFiles(".","*.profile"))
            {
               if (!profilename.ToLower().EndsWith("default.profile"))
               {
                  Profile profile = Profile.Load(profilename);
                  Loggable.LogInfo("merging default mapping into " + profilename);
                  CopyProfileMapping(defaultProfile, profile);
                  profile.Save();
               }
            }

            String[] baseProfiles = { "../../../Files/default.profile", "../../../Files/Example.profile", "../../../Files/F18C.profile", "../../../Files/Mi-24P.profile", "../../../Files/UH-1H.profile" };
            foreach (String profilename in baseProfiles)
            {
               Profile p = Profile.Load(profilename);
               CopyProfileMapping(defaultProfile, p);
               p.SaveAs(profilename);
            }

         } catch(Exception e)
         {
            Loggable.LogException("failed to copy default mappings", e);
         }
      }

      public static string[] SafeSplit(string s, char c)
      {
         if (s == null) return new string[] { "", "" };
         string[] result = s.Split(c);
         if (result.Length < 2 ) return new string[] { result[0], "" };
         return result;
      }
   }
}
