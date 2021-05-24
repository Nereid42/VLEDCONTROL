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


      public static void NoKeyPressed(Object o, KeyPressEventArgs e)
      {
         e.Handled = true;
      }


      public static String GetApplicationFolder()
      {
         return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
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

         //return Process.Start(ProcessInfo);
         return Process.Start(command,arguments);
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
   }
}
