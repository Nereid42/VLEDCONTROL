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


   public partial class QuickAddDialog : Form
   {
      public Profile Profile;

      private readonly ColorChooserDialog colorChooser = new ColorChooserDialog();


      private bool IsAdjusting = false;

      static String LastDeviceName = "";
      static String LastAircraft = "";

      private readonly Point[] CP2_Locations =
      {
         new Point(80,21), // 1
         new Point(55,21), // 2
         new Point(80,42), // 3
         new Point(55,42), // 4
         new Point(67,60), // 5
         new Point(67,66), // 6
         new Point(52,71), // 7
         new Point(59,78), // 8
         new Point(66,71), // 9
         new Point(75,78), // 10
         new Point(85,71), // 11
         new Point(151,157), // 12
         new Point(151,135), // 13
         new Point(151,113), // 14
         new Point(116,157), // 15
         new Point(116,135), // 16
         new Point(116,113) // 16
      };

      private readonly Point[] T50CM3_Locations =
      {
         new Point(50,111), // 1
         new Point(74,111), // 2
         new Point(98,111), // 3
         new Point(50,137), // 4
         new Point(74,137), // 5
         new Point(98,137)  // 6
      };

      public QuickAddDialog()
      {
         InitializeComponent();

         this.comboBoxLed.KeyPress += new KeyPressEventHandler(Tools.NoKeyPressed);
         this.comboBoxAircraft.KeyPress += new KeyPressEventHandler(Tools.NoKeyPressed);
         this.comboBoxDeviceName.KeyPress += new KeyPressEventHandler(Tools.NoKeyPressed);
         this.comboBoxEventNames.KeyPress += new KeyPressEventHandler(Tools.NoKeyPressed);
         this.buttonColorOn.BackColor = LedColor.DARKGREEN.ToSystemColor();
         this.buttonColorOn.ForeColor = Tools.GetBestForegroundColor(this.buttonColorOn.BackColor);
         this.buttonColorOff.BackColor = LedColor.BLACK.ToSystemColor();
         this.buttonColorOff.ForeColor = Tools.GetBestForegroundColor(this.buttonColorOff.BackColor);
      }

      private bool IsValid()
      {
         if (comboBoxAircraft.Text == null | comboBoxAircraft.Text.Length == 0) return false;
         if (comboBoxDeviceName.Text == null | comboBoxDeviceName.Text.Length == 0) return false;
         int deviceId = Tools.IndexOfSelectedComboBoxItem(comboBoxDeviceName);
         if (deviceId >= VLED.Engine.CurrentSettings.Devices.Count) return false;
         if(comboBoxEventNames.Text == null | comboBoxEventNames.Text.Length == 0) return false;
         if (Tools.IndexOfSelectedComboBoxItem(comboBoxEventNames)<0) return false;
         return true;
      }

      private void ValidateInput()
      {
         buttonOk.Enabled = IsValid();
      }

      public int GetEventId()
      {
         return Profile.MapPropertyId(comboBoxAircraft.Text, comboBoxEventNames.Text);
      }

      public String GetAircraft()
      {
         return this.comboBoxAircraft.Text;
      }

      public int GetLedNumber()
      {
         return Tools.IndexOfSelectedComboBoxItem(this.comboBoxLed);
      }

      public int GetDeviceId()
      {
         return Tools.IndexOfSelectedComboBoxItem(this.comboBoxDeviceName);
      }

      public LedColor GetColorOn()
      {
         return LedColor.FromSystemColor(this.buttonColorOn.BackColor);
      }
      public LedColor GetColorOff()
      {
         return LedColor.FromSystemColor(this.buttonColorOff.BackColor);
      }

      public LedColor GetColorFlashing()
      {
         return LedColor.FromSystemColor(this.buttonColorOff.BackColor);
      }

      internal string GetDescription()
      {
         return this.textBoxDescription.Text;
      }

      private void label3_Click(object sender, EventArgs e)
      {

      }

      private void QickAddDialog_Load(object sender, EventArgs e)
      {
         IsAdjusting = true;

         if (Profile == null) return;

         this.comboBoxAircraft.Items.Clear();
         foreach (String ac in Profile.GetAircraftList())
         {
            this.comboBoxAircraft.Items.Add(ac);
         }

         Tools.TrySelectComboBoxItem(this.comboBoxAircraft, VLED.MainWindow.textBoxAircraft.Text);
         if (Tools.IndexOfSelectedComboBoxItem(this.comboBoxAircraft)<0)
         {
            this.comboBoxAircraft.Text = LastAircraft;
         }


         if (this.comboBoxAircraft.Text!=null && this.comboBoxAircraft.Text.Length>0)
         {
            IsAdjusting = true;
            IReadOnlyCollection<String> eventNames = Profile.GetEventNamesForAircraft(comboBoxAircraft.Text);
            this.comboBoxEventNames.Items.Clear();
            foreach (String name in eventNames)
            {
               this.comboBoxEventNames.Items.Add(name);
            }
         }

         foreach (VirpilDevice device in VLED.Engine.CurrentSettings.Devices)
         {
            this.comboBoxDeviceName.Items.Add(device.Name);
         }
         this.comboBoxDeviceName.Text = LastDeviceName;

         Tools.SelectComboBoxItem(comboBoxLed, 0);

         ValidateInput();

         IsAdjusting = false;
      }

      private int FindBestMatch(Point[] points, int x, int y )
      {
         double best = double.MaxValue;
         int result = -1;
         for(int i=0; i<points.Length; i++)
         {
            double d = Tools.Distance(points[i].X, points[i].Y, x, y);
            if (d<best)
            {
               result = i;
               best = d;
            }
         }
         return result;
      }

      private void tabPageDeviceCP2_Click(object sender, EventArgs e)
      {
         if(e is System.Windows.Forms.MouseEventArgs)
         {
            System.Windows.Forms.MouseEventArgs mouseEvent = (MouseEventArgs)e;
            int x = mouseEvent.X;
            int y = mouseEvent.Y;
            int id = FindBestMatch(CP2_Locations, x, y);
            int deviceId = Tools.IndexOfSelectedComboBoxItem(comboBoxDeviceName);
            if (id>=0 && deviceId >= 0 && deviceId < VLED.Engine.CurrentSettings.Devices.Count)
            {
               VLED.Engine.HighlightLed(deviceId, id + 5, LedColor.WHITE);
               Tools.SelectComboBoxItem(comboBoxLed,id+5);
               ValidateInput();
            }
         }
      }

      private DialogResult OpenColorChooserAtButton(Button button)
      {
         Point componentLocation = button.PointToScreen(Point.Empty);
         colorChooser.Location = new Point(componentLocation.X, button.Size.Height + componentLocation.Y);
         colorChooser.StartPosition = FormStartPosition.Manual;
         return colorChooser.ShowDialog();
      }

      private void tabPageT50CM3_Click(object sender, EventArgs e)
      {
         if (e is System.Windows.Forms.MouseEventArgs)
         {
            System.Windows.Forms.MouseEventArgs mouseEvent = (MouseEventArgs)e;
            int x = mouseEvent.X;
            int y = mouseEvent.Y;
            int id = FindBestMatch(T50CM3_Locations, x, y);
            int deviceId = Tools.IndexOfSelectedComboBoxItem(comboBoxDeviceName);
            if (id >= 0 && deviceId >= 0 && deviceId < VLED.Engine.CurrentSettings.Devices.Count)
            {
               VLED.Engine.HighlightLed(deviceId, id+5, LedColor.WHITE);
               Tools.SelectComboBoxItem(comboBoxLed, id+5 );
               ValidateInput();
            }
         }
      }

      private void comboBoxAircraft_SelectedIndexChanged(object sender, EventArgs e)
      {
         if(!IsAdjusting)
         {
            IsAdjusting = true;
            IReadOnlyCollection<String> eventNames = Profile.GetEventNamesForAircraft(comboBoxAircraft.Text);
            this.comboBoxEventNames.Items.Clear();
            foreach (String name in eventNames)
            {
               this.comboBoxEventNames.Items.Add(name);
            }
            QuickAddDialog.LastAircraft = comboBoxAircraft.Text;
            ValidateInput();
            IsAdjusting = false;
         }
      }

      private void TestColor(Button button)
      {
         int deviceID = Tools.IndexOfSelectedComboBoxItem(comboBoxDeviceName);
         if (deviceID >= 0 )
         {
            Settings settings = VLED.Engine.CurrentSettings;
            VirpilDevice device = settings.GetDevice(deviceID);
            if (device != null)
            {
               int led = Tools.IndexOfSelectedComboBoxItem(this.comboBoxLed);

               device.SendCommand(led, LedColor.FromSystemColor(button.BackColor));
            }
         }
      }

      private void buttonTestColorOn_Click(object sender, EventArgs e)
      {
         TestColor(buttonColorOn);
      }

      private void buttonTestColorOff_Click(object sender, EventArgs e)
      {
         TestColor(buttonColorOff);
      }

      private void buttonColorOff_Click(object sender, EventArgs e)
      {
         if (OpenColorChooserAtButton(buttonColorOff) == DialogResult.OK)
         {
            buttonColorOff.BackColor = colorChooser.ResultColor;
            buttonColorOff.ForeColor = Tools.GetBestForegroundColor(buttonColorOff.BackColor);
         }
      }

      private void buttonColorOn_Click(object sender, EventArgs e)
      {
         if (OpenColorChooserAtButton(buttonColorOn) == DialogResult.OK)
         {
            buttonColorOn.BackColor = colorChooser.ResultColor;
            buttonColorOn.ForeColor = Tools.GetBestForegroundColor(buttonColorOn.BackColor);
         }
      }

      private void comboBoxEventNames_SelectedIndexChanged(object sender, EventArgs e)
      {
         if(!IsAdjusting)
         {
            ValidateInput();
         }
      }

      private void comboBoxDeviceName_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (!IsAdjusting)
         {
            IsAdjusting = true;
            QuickAddDialog.LastDeviceName = comboBoxDeviceName.Text;
            ValidateInput();
            IsAdjusting = false;
         }
      }
   }
}
