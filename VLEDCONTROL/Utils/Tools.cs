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
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace VLEDCONTROL
{
   public static class Tools 
   {
      private static readonly System.Globalization.CultureInfo EN_CI = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");


      public static int ToInt(String s)
      {
         try
         {
            return int.Parse(s);
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
            return double.Parse(s);
         }
         catch
         {
            return 0.0;
         }
      }

      public static string ToString(double value)
      {
         return String.Format(EN_CI, "{0:0.##}", value);
      }


      public static void NumericKeyPressed(Object o, KeyPressEventArgs e)
      {
         if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '.' || e.KeyChar == 8 )
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

      internal static void CopyDcsScripts(string dcsBasePath)
      {
         MakeDir(dcsBasePath + "/Scripts");
         MakeDir(dcsBasePath + "/Scripts/Hooks");
         MakeDir(dcsBasePath + "/Scripts/Hooks/vled");
         System.IO.File.Copy("Scripts/Hooks/VledExportHook.lua", dcsBasePath + "/Scripts/Hooks/VledExportHook.lua",true);
         System.IO.File.Copy("Scripts/Hooks/vled/VledExport.lua", dcsBasePath + "/Scripts/Hooks/vled/VledExport.lua",true);
      }

      internal static void RemoveDcsScripts(string dcsBasePath)
      {
         System.IO.File.Delete(dcsBasePath + "/Scripts/Hooks/VledExportHook.lua");
         System.IO.File.Delete(dcsBasePath + "/Scripts/Hooks/vled/VledExport.lua" );
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
         return result;
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

   }
}
