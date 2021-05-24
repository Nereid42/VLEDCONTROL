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
      }

      private void textBoxId_TextChanged(object sender, EventArgs e)
      {

      }
   }
}
