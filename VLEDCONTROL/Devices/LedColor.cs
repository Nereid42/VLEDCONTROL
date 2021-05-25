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

namespace VLEDCONTROL
{
   public class LedColor
   {
      public int red { get; set; } = 0;
      public int green { get; set; } = 0;
      public int blue { get; set; } = 0;

      public static readonly LedColor BLACK = new LedColor(0, 0, 0);
      public static readonly LedColor GRAY = new LedColor(128, 128, 128);
      public static readonly LedColor WHITE = new LedColor(255, 255, 255);

      public LedColor()
      {

      }

      public LedColor(int red, int green, int blue)
      {
         this.red = red;
         this.green = green;
         this.blue = blue;
      }

      public override string ToString()
      {
         return "#" + red.ToString("X2") + "/#" + green.ToString("X2") + "/#" + blue.ToString("X2");
      }

      public String AsString()
      {
         return red.ToString("X2") + "/" + green.ToString("X2") + "/" + blue.ToString("X2");
      }


      public System.Drawing.Color ToSystemColor()
      {
         return System.Drawing.Color.FromArgb(red,green,blue);
      }

      public static LedColor FromSystemColor(System.Drawing.Color color)
      {
         return new LedColor(color.R, color.G, color.B);
      }

      public override bool Equals(object obj)
      {
         if (obj is null) return false;
         if (obj.GetType() != typeof(LedColor)) return false;
         LedColor cmp = (LedColor)obj;
         return (this.red == cmp.red && this.green != cmp.green && this.blue != cmp.blue);
         }

      public override int GetHashCode()
      {
         return red.GetHashCode() + 255*green.GetHashCode() + 255*255*blue.GetHashCode();
      }
   }
}
