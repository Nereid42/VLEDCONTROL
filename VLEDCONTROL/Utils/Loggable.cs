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
using System.Diagnostics;

namespace VLEDCONTROL
{
   public class Loggable
   {
      public  enum LEVEL : int { URGEND = -1, OFF = 0, ERROR = 1, WARNING = 2, INFO = 3, DEBUG = 4, TRACE = 5 };

      static volatile LEVEL level = LEVEL.INFO;

      static void Log(LEVEL level, String message)
      {
         if (IsLoggable(level))
         {
            String timeStamp = DateTime.Now.ToString("HH:mm:ss");
            Trace.WriteLine(timeStamp + " [" + level.ToString().PadRight(6) + "]: " + message);
            Trace.Flush();
         }
      }

      public static void SetLogLevel(LEVEL level)
      {
         Loggable.level = level;
      }

      public static void LogUrgend(String message)
      {
         Log(LEVEL.URGEND, message);
      }

      public static void LogTrace(String message)
      {
         Log(LEVEL.TRACE, message);
      }

      public static void LogDebug(String message)
      {
         Log(LEVEL.DEBUG, message);
      }

      public static void LogInfo(String message)
      {
         Log(LEVEL.INFO, message);
      }

      public static void LogWarning(String message)
      {
         Log(LEVEL.WARNING, message);
      }

      public static void LogError(String message)
      {
         Log(LEVEL.ERROR, message);
      }

      public static void LogException(Exception e)
      {
         Log(LEVEL.ERROR, "EXCEPTION: "+e.GetType()+": "+e.Message+"\n"+e.StackTrace);
      }
      public static void LogException(String message, Exception e)
      {
         Log(LEVEL.ERROR, message+" [EXCEPTION: " + e.GetType() + ": " + e.Message+ "]\n" + e.StackTrace);
      }

      public static bool IsLoggable(LEVEL level)
      {
         return level <= Loggable.level;
      }

   }
}
