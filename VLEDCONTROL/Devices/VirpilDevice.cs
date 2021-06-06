using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLEDCONTROL
{
   public class VirpilDevice : Loggable
   {
      public String Name { get; set; } = "";
      public String USB_VID { get; set; } = "";
      public String USB_PID { get; set; } = "";

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
