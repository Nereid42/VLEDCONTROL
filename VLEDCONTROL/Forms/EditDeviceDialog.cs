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
   public partial class EditDeviceDialog : Form
   {
      public int Id;
      public VirpilDevice Device;

      public EditDeviceDialog()
      {
         InitializeComponent();
         this.textBoxId.KeyPress += new KeyPressEventHandler(IntegerKeyPressed);
      }


      private void IntegerKeyPressed(Object o, KeyPressEventArgs e)
      {
         if (e.KeyChar >= '0' && e.KeyChar <= '9' )
         {
            e.Handled = false;
            return;
         }
         e.Handled = true;
      }

      private void buttonOk_Click(object sender, EventArgs e)
      {
      }

      public int GetDeviceId()
      {
         try
         {
            return int.Parse(this.textBoxId.Text);
         }
         catch
         {
            // should never happen
            return 0;
         }
      }

      public String GetDeviceName()
      {
         return this.textBoxDeviceName.Text;
      }

      public String GetUsbVid()
      {
         return this.textBoxUsbVid.Text;
      }

      public String GetUsbPid()
      {
         return this.textBoxUsbPid.Text;
      }

      private void EditDeviceDialog_Load(object sender, EventArgs e)
      {

         this.textBoxId.Text = this.Id.ToString();
         if(Device != null)
         {
            this.textBoxDeviceName.Text = Device.Name;
            this.textBoxUsbVid.Text = Device.USB_VID;
            this.textBoxUsbPid.Text = Device.USB_PID;
         }
         else
         {
            this.textBoxUsbVid.Text = "3344";
         }
      }

      private void textBoxId_TextChanged(object sender, EventArgs e)
      {

      }

      private void textBoxDeviceName_TextChanged(object sender, EventArgs e)
      {

      }

      private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

      private void button2_Click(object sender, EventArgs e)
      {

      }

      private void comboBoxDevice_SelectedIndexChanged(object sender, EventArgs e)
      {
         int item = Tools.IndexOfSelectedComboBoxItem(this.comboBoxDevice);
         switch(item)
         {
            case 0:
               this.textBoxDeviceName.Text = "VPC Panel #1";
               this.textBoxUsbVid.Text = "3344";
               this.textBoxUsbPid.Text = "";
               break;
            case 1:
               this.textBoxDeviceName.Text = "VPC Panel #2";
               this.textBoxUsbVid.Text = "3344";
               this.textBoxUsbPid.Text = "025B";
               break;
            case 2:
               this.textBoxDeviceName.Text = "VPC SharKa-50 Panel";
               this.textBoxUsbVid.Text = "3344";
               this.textBoxUsbPid.Text = "025D";
               break;
            case 3:
               this.textBoxDeviceName.Text = "VPC Throttle MT-50CM3";
               this.textBoxUsbVid.Text = "3344";
               this.textBoxUsbPid.Text = "0194";
               break;
            case 4:
               this.textBoxDeviceName.Text = "VPC Stick WarBRD";
               this.textBoxUsbVid.Text = "3344";
               this.textBoxUsbPid.Text = "00CC";
               break;
            default:
               this.textBoxDeviceName.Text = "";
               this.textBoxUsbVid.Text = "3344";
               this.textBoxUsbPid.Text = "";
               break;
         }
      }
   }
}
