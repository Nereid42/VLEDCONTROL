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

namespace VLEDCONTROL
{
   public class LedColor
   {
      public int Red { get; set; } = 0;
      public int Green { get; set; } = 0;
      public int Blue { get; set; } = 0;

      public static readonly LedColor BLACK = new LedColor(0, 0, 0);
      public static readonly LedColor GRAY = new LedColor(128, 128, 128);
      public static readonly LedColor WHITE = new LedColor(255, 255, 255);
      public static readonly LedColor DARKGREEN = new LedColor(0, 64, 0);

      public LedColor()
      {

      }

      public LedColor(int red, int green, int blue)
      {
         this.Red = red;
         this.Green = green;
         this.Blue = blue;
      }

      public override string ToString()
      {
         return "#" + Red.ToString("X2") + "/#" + Green.ToString("X2") + "/#" + Blue.ToString("X2");
      }

      public String AsString()
      {
         return Red.ToString("X2") + "/" + Green.ToString("X2") + "/" + Blue.ToString("X2");
      }


      public System.Drawing.Color ToSystemColor()
      {
         return System.Drawing.Color.FromArgb(Red,Green,Blue);
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
         return (this.Red == cmp.Red && this.Green == cmp.Green && this.Blue == cmp.Blue);
      }

      public override int GetHashCode()
      {
         return Red.GetHashCode() + 255*Green.GetHashCode() + 255*255*Blue.GetHashCode();
      }
   }
}
