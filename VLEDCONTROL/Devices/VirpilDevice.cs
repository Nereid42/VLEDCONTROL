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
using HidSharp;

namespace VLEDCONTROL
{
   public class VirpilDevice : Loggable, IDisposable
   {
      public enum BOARDTYPE { DEFAULT = 0x64, ADDBOARD = 0x65, ONBOARD = 0x66, SLAVE = 0x67 }

      public String Name { get; set; } = "";
      public String USB_VID { get; set; } = "";
      public String USB_PID { get; set; } = "";

      private HidStream stream = null;

      private const int MAX_LED_CNT = 45;
      public int MinLedNumber = 0;
      public int MaxLedNumber = MAX_LED_CNT-1;

      private LedColor[] CurrentLedColors = new LedColor[MAX_LED_CNT];
      //private bool[] CurrentLedChanged = new bool[MAX_LED_CNT];
      private LedColor[] PreparedLedColors = new LedColor[MAX_LED_CNT];


      public VirpilDevice()
      {

      }

      public VirpilDevice(String name, String vid, String pid)
      {
         this.Name = name;
         this.USB_VID = vid;
         this.USB_PID = pid;
         ReopenStream();
      }

      public void Dispose()
      {
         if (stream != null)
         {
            stream.Dispose();
         }
         GC.SuppressFinalize(this);
      }

      public void SetVID(String vid)
      {
         this.USB_VID = vid;
         ReopenStream();
      }

      public void SetPID(String pid)
      {
         this.USB_PID = pid;
         ReopenStream();
      }

      private void ReopenStream()
      {
         Console.WriteLine("REOPEN entry");
         if (stream != null)
         {
            try
            {
               stream.Dispose();
            }
            catch
            {
               // LOGIT
            }
            stream = null;
         }

         try
         {
            if (USB_PID.Length == 0 || USB_VID.Length == 0) return;

            Console.WriteLine("USB PID: " + USB_PID);
            Console.WriteLine("USB VID: " + USB_VID);
            int vid = int.Parse(this.USB_VID, System.Globalization.NumberStyles.HexNumber);
            int pid = int.Parse(this.USB_PID, System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine("REOPEN vid=" + vid + ", pid=" + pid);

            HidDevice device = DeviceList.Local.GetHidDevices(vid, pid).FirstOrDefault(d => d.GetMaxFeatureReportLength() > 0);
            stream = device.Open();
            Console.WriteLine("REOPEN OPEN");
         }
         catch (Exception e)
         {
            Console.WriteLine("REOPEN EXCEPTION " + e.GetType());
            stream = null;
            // LOGIT
         }

      }

      private static byte GetByte(LedColor color)
      {
         byte[] rgb = new byte[] { (byte)color.red, (byte)color.green, (byte)color.blue };
         byte b = 0b_1000_0000;
         for (int i = 0; i < rgb.Length; i++)
         {
            byte c = rgb[i];
            if (c < 0x40)
            {
               c = 0;
            }
            else if (c < 0x80)
            {
               c = 1;
            }
            else if (c < 0xC0)
            {
               c = 2;
            }
            else
            {
               c = 2;
            }
            b |= (byte)(c << (2 * i));
         }
         return b;
      }


      private static byte[] CreateCommandPacket(BOARDTYPE boardType, int ledNumber, LedColor color)
      {
         var data = new byte[38];
         data[0] = 0x02;
         data[1] = (byte)boardType;
         data[2] = (byte)ledNumber;
         data[ledNumber + 4] = GetByte(color);
         data[37] = 0xf0;

         return data;
      }

      private void SendCommand(BOARDTYPE boardType, int ledNumber, LedColor color)
      {
         if (stream is null)
         {
            ReopenStream();
            if (stream == null) return;
         }

         var packet = CreateCommandPacket(boardType, ledNumber, color);

         try
         {
            LogDebug("sending command led "+ledNumber+" color "+color+" to device "+this);
            stream.SetFeature(packet);
         }
         catch
         {
            Console.WriteLine("CLOSED");
            stream.Dispose();
            stream = null;
            // LOGIT
         }
      }

      public void SendCommand(int ledIndex, LedColor color)
      {
         if(ledIndex<5)
         {
            SendCommand(BOARDTYPE.ADDBOARD, ledIndex, color);
         }
         else if(ledIndex<25)
         {
            SendCommand(BOARDTYPE.ONBOARD, ledIndex-4, color);
         }
         else
         {
            SendCommand(BOARDTYPE.SLAVE, ledIndex - 24, color);
         }
      }

      public void SendResetCommand()
      {
         SendCommand(BOARDTYPE.DEFAULT, 0, LedColor.BLACK);
      }


      public void Reset()
      {
         for(int i=0; i < MAX_LED_CNT; i++)
         {
            CurrentLedColors[i] = null;
            PreparedLedColors[i] = null;
         }
      }


      public void PrepareColor(int ledNumber, LedColor color)
      {
         if (ledNumber >= MAX_LED_CNT)
         {
            LogError("invalid LED index for device " + Name + ": " + ledNumber);
            return;
         }
         PreparedLedColors[ledNumber] = color;
      }

      public LedColor SetCurrentColor(int ledNumber)
      {
         if (ledNumber >= MAX_LED_CNT)
         {
            LogError("invalid LED index for device " + Name + ": " + ledNumber);
            return null;
         }
         if (PreparedLedColors[ledNumber] == null)
         {
            //CurrentLedChanged[ledNumber] = false;
            return null;
         }
         if (!PreparedLedColors[ledNumber].Equals(CurrentLedColors[ledNumber]))
         {
            //CurrentLedChanged[ledNumber] = true;
            CurrentLedColors[ledNumber] = PreparedLedColors[ledNumber];
            return CurrentLedColors[ledNumber];
         }
         //CurrentLedChanged[ledNumber] = false;
         return null;
      }

      public override string ToString()
      {
         return "[" + Name + ":" + USB_VID + ":" + USB_PID + ")";
      }


   }
}
