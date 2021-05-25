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
