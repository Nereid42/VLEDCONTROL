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
   public class Color
   {
      public int red { get; set; } = 0;
      public int green { get; set; } = 0;
      public int blue { get; set; } = 0;

      public static readonly Color BLACK = new Color(0, 0, 0);
      public static readonly Color GRAY = new Color(128, 128, 128);
      public static readonly Color WHITE = new Color(255, 255, 255);

      public Color()
      {

      }

      public Color(int red, int green, int blue)
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

      public static Color FromSystemColor(System.Drawing.Color color)
      {
         return new Color(color.R, color.G, color.B);
      }

      public override bool Equals(object obj)
      {
         if (obj is null) return false;
         if (obj.GetType() != typeof(Color)) return false;
         Color cmp = (Color)obj;
         if (this.red != cmp.red) return false;
         if (this.green != cmp.green) return false;
         if (this.blue != cmp.blue) return false;
         return true;
      }

      public override int GetHashCode()
      {
         return red.GetHashCode() + 255*green.GetHashCode() + 255*255*blue.GetHashCode();
      }
   }
}
