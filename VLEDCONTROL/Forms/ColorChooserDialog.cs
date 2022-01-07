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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLEDCONTROL
{
   public partial class ColorChooserDialog : Form
   {
      private const int HI  = 255;
      private const int MED = 128;
      private const int LOW = 64;
      private const int NONE = 0;

      public readonly LedColor Color = new LedColor();
      public System.Drawing.Color ResultColor { get; private set; } = System.Drawing.Color.Black;

      public ColorChooserDialog()
      {
         InitializeComponent();
      }

      private void ColorChooserDialog_Load(object sender, EventArgs e)
      {
         buttonBlack.BackColor = System.Drawing.Color.Black;
         //
         buttonWhite1.BackColor = System.Drawing.Color.FromArgb(LOW, LOW, LOW);
         buttonWhite2.BackColor = System.Drawing.Color.FromArgb(MED, MED, MED);
         buttonWhite3.BackColor = System.Drawing.Color.FromArgb(HI,  HI,  HI );
         //
         buttonRed1.BackColor = System.Drawing.Color.FromArgb(LOW, NONE, NONE);
         buttonRed2.BackColor = System.Drawing.Color.FromArgb(MED, NONE, NONE);
         buttonRed3.BackColor = System.Drawing.Color.FromArgb(HI,  NONE, NONE);
         //
         buttonGreen1.BackColor = System.Drawing.Color.FromArgb(NONE, LOW, NONE);
         buttonGreen2.BackColor = System.Drawing.Color.FromArgb(NONE, MED, NONE);
         buttonGreen3.BackColor = System.Drawing.Color.FromArgb(NONE, HI,  NONE);
         //
         buttonBlue1.BackColor = System.Drawing.Color.FromArgb(NONE, NONE, LOW);
         buttonBlue2.BackColor = System.Drawing.Color.FromArgb(NONE, NONE, MED);
         buttonBlue3.BackColor = System.Drawing.Color.FromArgb(NONE, NONE, HI );
         //
         buttonYellow1.BackColor = System.Drawing.Color.FromArgb(LOW, LOW, NONE);
         buttonYellow2.BackColor = System.Drawing.Color.FromArgb(MED, MED, NONE);
         buttonYellow3.BackColor = System.Drawing.Color.FromArgb(HI,  HI,  NONE);
         //
         buttonCyan1.BackColor = System.Drawing.Color.FromArgb(NONE, LOW, LOW);
         buttonCyan2.BackColor = System.Drawing.Color.FromArgb(NONE, MED, MED);
         buttonCyan3.BackColor = System.Drawing.Color.FromArgb(NONE, HI,  HI );
         //
         buttonMagenta1.BackColor = System.Drawing.Color.FromArgb(LOW, NONE, LOW);
         buttonMagenta2.BackColor = System.Drawing.Color.FromArgb(MED, NONE, MED);
         buttonMagenta3.BackColor = System.Drawing.Color.FromArgb(HI,  NONE, HI );
         //
         SetCustomColor();
      }

      private static int UpDownToRGB(System.Windows.Forms.NumericUpDown updown)
      {
         switch(updown.Value)
         {
            case 0: return 0;
            case 1: return 64;
            case 2: return 128;
            case 3: return 255;
            default: return 0;
         }
      }

      private void SetCustomColor()
      {
         int r = UpDownToRGB(numericUpDownRed);
         int g = UpDownToRGB(numericUpDownGreen);
         int b = UpDownToRGB(numericUpDownBlue);
         System.Drawing.Color color = System.Drawing.Color.FromArgb(r, g, b);
         buttonCustomColor.BackColor = color;
         textBoxColorCodes.Text = r.ToString("X2") + "  /  " + g.ToString("X2") + "  /  "+ b.ToString("X2");
      }

      private void SetResultcolor(Button button)
      {
         Color.Red = button.BackColor.R;
         Color.Green = button.BackColor.G;
         Color.Blue = button.BackColor.B;
         ResultColor = button.BackColor;
      }

      private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
      {
         SetCustomColor();
      }

      private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
      {
         SetCustomColor();
      }

      private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
      {
         SetCustomColor();
      }

      private void buttonCustomColor_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonCustomColor);
      }

      private void buttonBlack_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonBlack);
      }

      private void buttonWhite1_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonWhite1);
      }

      private void buttonWhite2_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonWhite2);
      }

      private void buttonWhite3_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonWhite3);
      }

      private void buttonRed1_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonRed1);
      }

      private void buttonRed2_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonRed2);
      }

      private void buttonRed3_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonRed3);
      }

      private void buttonGreen1_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonGreen1);
      }

      private void buttonGreen2_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonGreen2);
      }

      private void buttonGreen3_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonGreen3);
      }

      private void buttonBlue1_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonBlue1);
      }

      private void buttonBlue2_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonBlue2);
      }

      private void buttonBlue3_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonBlue3);
      }

      private void buttonYellow1_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonYellow1);
      }

      private void buttonYellow2_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonYellow2);
      }

      private void buttonYellow3_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonYellow3);
      }

      private void buttonCyan1_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonCyan1);
      }

      private void buttonCyan2_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonCyan2);
      }

      private void buttonCyan3_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonCyan3);
      }

      private void buttonMagenta1_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonMagenta1);
      }

      private void buttonMagenta2_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonMagenta2);
      }

      private void buttonMagenta3_Click(object sender, EventArgs e)
      {
         SetResultcolor(buttonMagenta3);
      }
   }
}
