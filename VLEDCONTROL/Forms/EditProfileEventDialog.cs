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
   public partial class EditProfileEventDialog : Form
   {
      public Profile Profile;
      public Profile.ProfileEvent Event;

      private bool IsAdjusting = false;

      private readonly ColorChooserDialog colorChooser = new ColorChooserDialog();

      static String LastAircraft = "";

      public EditProfileEventDialog()
      {
         InitializeComponent();
         this.textBoxEventId.KeyPress += new KeyPressEventHandler(Tools.IntegerKeyPressed);
         this.textBoxDeviceId.KeyPress += new KeyPressEventHandler(Tools.IntegerKeyPressed);
         this.comboBoxLed.KeyPress += new KeyPressEventHandler(Tools.NoKeyPressed);
         this.comboBoxPrimaryCondition.KeyPress += new KeyPressEventHandler(Tools.NoKeyPressed);
         this.comboBoxSecondaryCondition.KeyPress += new KeyPressEventHandler(Tools.NoKeyPressed);
         this.textBoxPrimaryValue.KeyPress += new KeyPressEventHandler(NumericKeyPressed); 
         this.textBoxSecondaryValue.KeyPress += new KeyPressEventHandler(NumericKeyPressed);
         this.comboBoxEventNames.KeyPress += new KeyPressEventHandler(Tools.NoKeyPressed);
         this.comboBoxAircraft.KeyPress += new KeyPressEventHandler(this.ComboBoxAircraftTextChanged);

         this.comboBoxAircraft.TextChanged += new EventHandler(this.ComboBoxAircraftTextChanged);
      }

      private void NumericKeyPressed(object sender, KeyPressEventArgs e)
      {
         Tools.NumericKeyPressed(sender, e);
         TextBox box = (TextBox)sender;
         if(!e.Handled)
         {
            if (e.KeyChar == '-' && box.SelectionStart != 0)
            {
               e.Handled = true;
            }
         }
      }

      private bool IsValid()
      {
         if (comboBoxAircraft.Text == null | comboBoxAircraft.Text.Length == 0) return false;
         if (!Tools.IsInteger(textBoxEventId.Text)) return false;
         if (!Tools.IsInteger(textBoxDeviceId.Text)) return false;
         if (Tools.ToInt(textBoxDeviceId.Text) >= VLED.Engine.CurrentSettings.Devices.Count) return false;
         return true;
      }


      private void ValidateInput()
      {
         buttonOk.Enabled = IsValid();
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
         return Tools.IndexOfSelectedComboBoxItem(this.comboBoxLed);
      }

      public int GetDeviceId()
      {
         return Tools.ToInt(this.textBoxDeviceId.Text);
      }

      public LedColor GetColorOn()
      {
         return LedColor.FromSystemColor(this.buttonColor1.BackColor);
      }

      public LedColor GetColorFlashing()
      {
         return LedColor.FromSystemColor(this.buttonColor2.BackColor);
      }

      internal string GetDescription()
      {
         return this.textBoxDescription.Text;
      }


      private void ComboBoxAircraftTextChanged(Object o, EventArgs e)
      {
         if (!IsAdjusting)
         {
            String aircraft = this.comboBoxAircraft.Text;
            IReadOnlyCollection<String> eventNames = Profile.GetEventNamesForAircraft(aircraft);
            if(eventNames!=null && eventNames.Count>0)
            {
               IsAdjusting = true;

               this.comboBoxEventNames.Items.Clear();
               foreach (String name in eventNames)
               {
                  this.comboBoxEventNames.Items.Add(name);
               }

               int id = Tools.ToInt(this.textBoxEventId.Text);
               comboBoxEventNames.Text = Profile.MapPropertyName(aircraft, id);

               ValidateInput();

               IsAdjusting = false;
            }
            else
            {
               comboBoxEventNames.Items.Clear();
               comboBoxEventNames.Text = "";
            }
         }
      }

      private void GroupBoxEvent_Enter(object sender, EventArgs e)
      {

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

         foreach (VirpilDevice device in VLED.Engine.CurrentSettings.Devices)
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
            this.comboBoxSecondaryCondition.Text = Event.SecondaryCondition.Length==0 ? "-" : Event.SecondaryCondition;
            this.textBoxSecondaryValue.Text = Event.SecondaryValue.ToString();
            //
            //
            // Device
            this.textBoxDeviceId.Text = Event.DeviceId.ToString();
            Tools.SelectComboBoxItem(this.comboBoxDeviceName, Event.DeviceId);
            // LEDs
            this.comboBoxLed.Text = this.comboBoxLed.Items[Event.LedNumber].ToString();
            // Colors
            this.buttonColor1.BackColor = Event.ColorOn.ToSystemColor();
            this.buttonColor1.ForeColor = Tools.GetBestForegroundColor(this.buttonColor1.BackColor);
            this.buttonColor2.BackColor = Event.ColorFlashing.ToSystemColor();
            this.buttonColor2.ForeColor = Tools.GetBestForegroundColor(this.buttonColor2.BackColor);
            //
            this.textBoxDescription.Text = Event.Description;
         }
         else
         {


            Tools.TrySelectComboBoxItem(this.comboBoxAircraft, VLED.MainWindow.textBoxAircraft.Text);
            if (Tools.IndexOfSelectedComboBoxItem(this.comboBoxAircraft) < 0)
            {
               this.comboBoxAircraft.Text = LastAircraft;
            }
            IReadOnlyCollection<String> eventNames = Profile.GetEventNamesForAircraft(this.comboBoxAircraft.Text);
            this.comboBoxEventNames.Items.Clear();
            foreach (String name in eventNames)
            {
               this.comboBoxEventNames.Items.Add(name);
            }

            Tools.SelectComboBoxItem(this.comboBoxDeviceName, 0);
            this.textBoxDeviceId.Text = "0";
            this.textBoxEventId.Text = "0";
            //
            Tools.SelectComboBoxItem(this.comboBoxPrimaryCondition, 1);
            Tools.SelectComboBoxItem(this.comboBoxSecondaryCondition, 0);
            this.textBoxPrimaryValue.Text = "0";
            this.textBoxSecondaryValue.Text = "0";
            //
            Tools.SelectComboBoxItem(this.comboBoxLed, 0);
            // Colors
            this.buttonColor1.BackColor = LedColor.GRAY.ToSystemColor();
            this.buttonColor2.BackColor = LedColor.GRAY.ToSystemColor();
            //
            this.textBoxDescription.Text = "";
         }

         ValidateInput();

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
            ValidateInput();
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
            buttonColor1.ForeColor = Tools.GetBestForegroundColor(buttonColor1.BackColor);
         }
      }

      private void buttonColor2_Click(object sender, EventArgs e)
      {
         if (OpenColorChooserAtButton(buttonColor2) == DialogResult.OK)
         {
            buttonColor2.BackColor = colorChooser.ResultColor;
            buttonColor2.ForeColor = Tools.GetBestForegroundColor(buttonColor2.BackColor);
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
               int led = Tools.IndexOfSelectedComboBoxItem(this.comboBoxLed);

               device.SendCommand(led, LedColor.FromSystemColor(button.BackColor));
            }
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
            ValidateInput();
            IsAdjusting = false;
         }
      }

      private void comboBoxDeviceName_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (!IsAdjusting)
         {
            IsAdjusting = true;

            int id = Tools.IndexOfSelectedComboBoxItem(comboBoxDeviceName);
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

            EditProfileEventDialog.LastAircraft = comboBoxAircraft.Text;

            IsAdjusting = false;

            ValidateInput();
         }
      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {

      }

      private void buttonOk_Click(object sender, EventArgs e)
      {

      }

      private void buttonSetDefault_Click(object sender, EventArgs e)
      {
         Settings settings = VLED.Engine.CurrentSettings;
         VirpilDevice device = settings.GetDevice(Tools.ToInt(this.textBoxDeviceId.Text));
         if (device != null)
         {
            device.SendResetCommand();
         }
      }

      private void comboBoxLed_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

      private void groupBoxTestLed_Enter(object sender, EventArgs e)
      {

      }

      private void buttonSetPrimaryValue0_Click(object sender, EventArgs e)
      {
         this.textBoxPrimaryValue.Text = "0";
         this.textBoxPrimaryValue.Focus();
      }

      private void buttonSetPrimaryValue1_Click(object sender, EventArgs e)
      {
         this.textBoxPrimaryValue.Text = "1";
         this.textBoxPrimaryValue.Focus();
      }

      private void buttonSetSecondaryValue0_Click(object sender, EventArgs e)
      {
         this.textBoxSecondaryValue.Text = "0";
         this.textBoxSecondaryValue.Focus();
      }

      private void buttonSetSecondaryValue1_Click(object sender, EventArgs e)
      {
         this.textBoxSecondaryValue.Text = "1";
         this.textBoxSecondaryValue.Focus();
      }

      private void buttonCurrentAircraft_Click(object sender, EventArgs e)
      {

      }

      private void SetAndHighlightOLed(int led)
      {
         if (textBoxDeviceId.Text is null || textBoxDeviceId.Text.Length == 0) return;
         int deviceId = Tools.ToInt(textBoxDeviceId.Text);
         led = led + 4;
         VLED.Engine.HighlightLed(deviceId, led, LedColor.WHITE);
         Tools.SelectComboBoxItem(comboBoxLed, led);
      }

      private void buttonLed1_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(1);
      }

      private void buttonLed2_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(2);
      }

      private void buttonLed3_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(3);
      }

      private void buttonLed04_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(4);
      }

      private void buttonLed5_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(5);
      }

      private void buttonLed6_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(6);
      }

      private void buttonLed7_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(7);
      }

      private void buttonLed8_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(8);
      }

      private void buttonLed9_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(9);
      }

      private void buttonLed10_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(10);
      }

      private void buttonLed11_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(11);
      }

      private void buttonLed12_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(12);
      }

      private void buttonLed13_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(13);
      }

      private void buttonLed14_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(14);
      }

      private void buttonLed15_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(15);
      }

      private void buttonLed16_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(16);
      }

      private void buttonLed17_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(17);
      }

      private void buttonLed18_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(18);
      }

      private void buttonLed19_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(19);
      }

      private void buttonLed20_Click(object sender, EventArgs e)
      {
         SetAndHighlightOLed(20);
      }
   }
}
