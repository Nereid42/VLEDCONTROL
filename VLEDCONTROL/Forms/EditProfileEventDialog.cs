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
   public partial class EditProfileEventDialog : Form
   {
      public Profile Profile;
      public Profile.ProfileEvent Event;

      private bool IsAdjusting = false;

      ColorChooserDialog colorChooser = new ColorChooserDialog();

      public EditProfileEventDialog()
      {
         InitializeComponent();
         this.textBoxEventId.KeyPress += new KeyPressEventHandler(Tools.IntegerKeyPressed);
         this.textBoxDeviceId.KeyPress += new KeyPressEventHandler(Tools.IntegerKeyPressed);
         this.comboBoxLed.KeyPress += new KeyPressEventHandler(Tools.NoKeyPressed);
         this.comboBoxPrimaryCondition.KeyPress += new KeyPressEventHandler(Tools.NoKeyPressed);
         this.comboBoxSecondaryCondition.KeyPress += new KeyPressEventHandler(Tools.NoKeyPressed);
         this.textBoxPrimaryValue.KeyPress += new KeyPressEventHandler(Tools.NumericKeyPressed);
         this.textBoxSecondaryValue.KeyPress += new KeyPressEventHandler(Tools.NumericKeyPressed);
         this.comboBoxEventNames.KeyPress += new KeyPressEventHandler(Tools.NoKeyPressed);

         this.comboBoxAircraft.TextChanged += new EventHandler(this.ComboBoxAircraftTextChanged);
      }

      public int GetEventId()
      {
         return Tools.ToInt(this.textBoxEventId.Text);
      }

      public String GetAircraft()
      {
         return this.comboBoxAircraft.Text;
      }

      public String GetPrimaryCondition()
      {
         return this.comboBoxPrimaryCondition.Text;
      }
      public String GetSecondaryCondition()
      {
         return this.comboBoxSecondaryCondition.Text;
      }

      public double GetPrimaryValue()
      {
         return Tools.ToDouble(this.textBoxPrimaryValue.Text);
      }

      public double GetSecondaryValue()
      {
         return Tools.ToDouble(this.textBoxSecondaryValue.Text);
      }

      public int GetLedNumber()
      {
         return IndexOfSelectedItem(this.comboBoxLed);
      }

      public int GetDeviceId()
      {
         return Tools.ToInt(this.textBoxDeviceId.Text);
      }

      public Color GetColorOn()
      {
         return Color.FromSystemColor(this.buttonColor1.BackColor);
      }

      public Color GetColorFlashing()
      {
         return Color.FromSystemColor(this.buttonColor2.BackColor);
      }

      internal string GetDescription()
      {
         return this.textBoxDescription.Text;
      }


      private void ComboBoxAircraftTextChanged(Object o, EventArgs e)
      {
         String aircraft = this.comboBoxAircraft.Text;
         if(comboBoxAircraft.Items.Contains(aircraft))
         {
            IsAdjusting = true;

            IReadOnlyCollection<String> eventNames = Profile.GetEventNamesForAircraft(aircraft);
            this.comboBoxEventNames.Items.Clear();
            foreach (String name in eventNames)
            {
               this.comboBoxEventNames.Items.Add(name);
            }

            int id = Tools.ToInt(this.textBoxEventId.Text);
            comboBoxEventNames.Text = Profile.MapPropertyName(aircraft, id);

            IsAdjusting = false;
         }
         else
         {
            comboBoxEventNames.Items.Clear();
            comboBoxEventNames.Text = "";
         }
      }

      private void GroupBoxEvent_Enter(object sender, EventArgs e)
      {

      }

      private int IndexOfSelectedItem(ComboBox box)
      {
         int result = -1;
         foreach (Object item in box.Items)
         {
            result++;
            if (item.Equals(box.Text)) return result;
         }
         return result;
      }

      private void SelectItem(ComboBox box, int index)
      {
         if(index<box.Items.Count)
         {
            box.Text = box.Items[index].ToString();
         }
      }

      private void EditProfileEventDialog_Load(object sender, EventArgs e)
      {
         IsAdjusting = true;

         if (Profile == null) return;

         this.comboBoxAircraft.Items.Clear();
         foreach (String ac in Profile.GetAircraftList())
         {
            this.comboBoxAircraft.Items.Add(ac);
         }

         foreach(VirpilDevice device in VLED.Engine.CurrentSettings.Devices)
         {
            this.comboBoxDeviceName.Items.Add(device.Name);
         }

         if (Event != null)
         {
            String aircraft = Event.Aircraft;
            //
            this.textBoxEventId.Text = Event.Id.ToString();
            //
            this.comboBoxAircraft.Text = aircraft;
            //
            //
            IReadOnlyCollection<String> eventNames = Profile.GetEventNamesForAircraft(aircraft);
            this.comboBoxEventNames.Items.Clear();
            foreach (String name in eventNames)
            {
               this.comboBoxEventNames.Items.Add(name);
            }
            String eventName = Profile.MapPropertyName(aircraft, Event.Id);
            this.comboBoxEventNames.Text = eventName;
            //
            // Conditions
            //
            this.comboBoxPrimaryCondition.Text = Event.PrimaryCondition;
            this.textBoxPrimaryValue.Text = Event.PrimaryValue.ToString();
            this.comboBoxSecondaryCondition.Text = Event.SecondaryCondition.Length==0?"NONE" : Event.SecondaryCondition;
            this.textBoxSecondaryValue.Text = Event.SecondaryValue.ToString();
            //
            //
            // Device
            this.textBoxDeviceId.Text = Event.DeviceId.ToString();
            SelectItem(this.comboBoxDeviceName, Event.DeviceId);
            // LEDs
            this.comboBoxLed.Text = this.comboBoxLed.Items[Event.LedNumber].ToString();
            // Colors
            this.buttonColor1.BackColor = Event.ColorOn.ToSystemColor();
            this.buttonColor2.BackColor = Event.ColorFlashing.ToSystemColor();
            //
            this.textBoxDescription.Text = Event.Description;
         }
         else
         {
            SelectItem(this.comboBoxDeviceName, 0);
            this.textBoxDeviceId.Text = "0";
            this.textBoxEventId.Text = "0";
            //
            SelectItem(this.comboBoxPrimaryCondition, 1);
            SelectItem(this.comboBoxSecondaryCondition, 0);
            this.textBoxPrimaryValue.Text = "0";
            this.textBoxSecondaryValue.Text = "0";
            //
            SelectItem(this.comboBoxLed, 0);
            // Colors
            this.buttonColor1.BackColor = Color.GRAY.ToSystemColor();
            this.buttonColor2.BackColor = Color.GRAY.ToSystemColor();
            //
            this.textBoxDescription.Text = "";
         }
         IsAdjusting = false;
      }

      private void comboBoxEventNames_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (!IsAdjusting)
         {
            String eventName = this.comboBoxEventNames.Text;
            int id = Profile.MapPropertyId(comboBoxAircraft.Text, eventName);
            IsAdjusting = true;
            this.textBoxEventId.Text = id.ToString();
            IsAdjusting = false;
         }
      }

      private void textBoxEventId_TextChanged(object sender, EventArgs e)
      {
         if (!IsAdjusting)
         {
            IsAdjusting = true;

            int id = Tools.ToInt(this.textBoxEventId.Text);

            String eventName = Profile.MapPropertyName(comboBoxAircraft.Text,id);
            if (eventName!=null)
            {
               this.comboBoxEventNames.Text = eventName;
            }
            else
            {
               this.comboBoxEventNames.Text = "";
            }
            IsAdjusting = false;
         }
      }


      private DialogResult OpenColorChooserAtButton(Button button)
      {
         Point componentLocation = button.PointToScreen(Point.Empty);
         colorChooser.Location = new Point(componentLocation.X, button.Size.Height + componentLocation.Y);
         colorChooser.StartPosition = FormStartPosition.Manual;
         return colorChooser.ShowDialog();
      }

      private void button1_Click(object sender, EventArgs e)
      {                  
         if (OpenColorChooserAtButton(buttonColor1) == DialogResult.OK)
         {
            buttonColor1.BackColor = colorChooser.ResultColor;
         }
      }

      private void buttonColor2_Click(object sender, EventArgs e)
      {
         if (OpenColorChooserAtButton(buttonColor2) == DialogResult.OK)
         {
            buttonColor2.BackColor = colorChooser.ResultColor;
         }
      }

      private void TestColor(Button button)
      {
         if (Tools.IsInteger(textBoxDeviceId.Text))
         {
            Settings settings = VLED.Engine.CurrentSettings;
            VirpilDevice device = settings.GetDevice(Tools.ToInt(this.textBoxDeviceId.Text));
            if(device!=null)
            {
               int led = IndexOfSelectedItem(this.comboBoxLed);

               String command = settings.VirpilLedControl;
               String r = button.BackColor.R.ToString("X2");
               String g = button.BackColor.G.ToString("X2");
               String b = button.BackColor.B.ToString("X2");

               String arguments = device.USB_VID + " " + device.USB_PID + " " + led + " " + r + " " + g + " " + b;

               this.textBoxCommand.Text = command + " " + arguments;
               this.textBoxCommand.Select(this.textBoxCommand.Text.Length, 0);
               Tools.ExecuteCommand(command, arguments);
            }
         }
         else
         {
            textBoxCommand.Text = "no device";
         }
      }

      private void buttonTestColor1_Click(object sender, EventArgs e)
      {
         TestColor(this.buttonColor1);
      }

      private void buttonTestColor2_Click(object sender, EventArgs e)
      {
         TestColor(this.buttonColor2);
      }

      private void textBoxDeviceId_TextChanged(object sender, EventArgs e)
      {
         if (!IsAdjusting)
         {
            IsAdjusting = true;

            int id = Tools.ToInt(this.textBoxDeviceId.Text);

            VirpilDevice device = VLED.Engine.CurrentSettings.GetDevice(id);
            if(device!=null)
            {
               this.comboBoxDeviceName.Text = device.Name;
            }
            else
            {
               this.comboBoxDeviceName.Text = "";
            }

            IsAdjusting = false;
         }
      }

      private void comboBoxDeviceName_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (!IsAdjusting)
         {
            IsAdjusting = true;

            int id = IndexOfSelectedItem(comboBoxDeviceName);
            if(id>=0)
            {
               textBoxDeviceId.Text = id.ToString();
            }
            else
            {
               textBoxDeviceId.Text = "";
            }

            IsAdjusting = false;
         }
      }

      private void comboBoxAircraft_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (!IsAdjusting)
         {
            IsAdjusting = true;

            IReadOnlyCollection<String> eventNames = Profile.GetEventNamesForAircraft(this.comboBoxAircraft.Text);
            this.comboBoxEventNames.Items.Clear();
            foreach (String name in eventNames)
            {
               this.comboBoxEventNames.Items.Add(name);
            }

            int id = Tools.ToInt(this.textBoxEventId.Text);
            comboBoxEventNames.Text = Profile.MapPropertyName(this.comboBoxAircraft.Text, id);

            IsAdjusting = false;
         }
      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {

      }

      private void buttonOk_Click(object sender, EventArgs e)
      {

      }
   }
}
