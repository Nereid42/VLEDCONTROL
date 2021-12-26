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
   public partial class MainWindowForm : Form
   {
      public readonly UiController Controller;

      public MainWindowForm()
      {
         InitializeComponent();
         Controller = new UiController(this);
         this.comboBoxLogLevel.KeyPress += new KeyPressEventHandler(LogLevelComboBoxKeyPressed);
         this.listViewMapping.ListViewItemSorter = new NumericListViewSorter();

         this.comboBoxProfileFilterAircraft.KeyPress += new KeyPressEventHandler(Tools.NoKeyPressed);
         this.comboBoxProfileFilterDevice.KeyPress += new KeyPressEventHandler(Tools.NoKeyPressed);
         this.comboBoxMappingFilterAircraft.KeyPress += new KeyPressEventHandler(Tools.NoKeyPressed);
      }


      private void LogLevelComboBoxKeyPressed(Object o, KeyPressEventArgs e)
      {
         // make Loglevel Combobox non editable
         e.Handled = true;
      }

      private void MenuItemExit_Click(object sender, EventArgs e)
      {
         VLED.Exit();
      }

      private void MenuItemAbout_Click(object sender, EventArgs e)
      {

      }

      private void MainWindowForm_Load(object sender, EventArgs e)
      {
         // Check if this is the First run of VLEDCONTROL
         if (VLED.IsFirstRun)
         {
            VLED.ShowInstallScriptsDialog(true);
         }
         UpdateMappingStatistics();

         // status of engine
         Controller.SetEngineStarted(VLED.Engine.IsRunning);
      }

      public void UpdateMappingStatistics()
      {
         labelMappingNumberOfMappings.Text = VLED.Engine.CurrentProfile.MappingEntries.Count + " Mappings";
         labelMappingNumberOfAircrafts.Text = VLED.Engine.CurrentProfile.GetAircraftList().Count + " Aircrafts";
      }

      private void listViewProfileEvents_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (listViewProfileEvents.SelectedIndices.Count == 0)
         {
            buttonProfileRemove.Enabled = false;
            buttonProfileDuplicate.Enabled = false;
            buttonProfileEdit.Enabled = false;
            buttonProfileDown.Enabled = false;
            buttonProfileUp.Enabled = false;
            buttonProfileEnable.Enabled = false;
         }
         else
         {
            int selectedIndex = listViewProfileEvents.SelectedIndices[0];
            buttonProfileRemove.Enabled = true;
            buttonProfileDuplicate.Enabled = true;
            buttonProfileEdit.Enabled = true;
            buttonProfileDown.Enabled = (selectedIndex < listViewProfileEvents.Items.Count - 1 );
            buttonProfileUp.Enabled = (selectedIndex > 0 );
            buttonProfileEnable.Enabled = (selectedIndex > 0);

            int index = (int)listViewProfileEvents.Items[selectedIndex].Tag;
            if(index < VLED.Engine.CurrentProfile.ProfileEvents.Count)
            {
               Profile.ProfileEvent profileEvent = VLED.Engine.CurrentProfile.ProfileEvents[index];
               buttonProfileEnable.Text = profileEvent.Enabled ? "Disable" : "Enable";
               //
               if (checkBoxHighlightLed.Checked)
               {
                  // highlight LED
                  int deviceId = profileEvent.DeviceId;
                  int led = profileEvent.LedNumber;
                  VLED.Engine.HighlightLed(deviceId, led, LedColor.WHITE);
               }
            }
         }

      }

      private void label1_Click(object sender, EventArgs e)
      {

      }

      private void label1_Click_1(object sender, EventArgs e)
      {

      }

      private void buttonMainStart_Click(object sender, EventArgs e)
      {
         Controller.StartStopEngine();
      }

      private void label1_Click_2(object sender, EventArgs e)
      {

      }

      private void label1_Click_3(object sender, EventArgs e)
      {

      }

      private void buttonMainLoadProfile_Click(object sender, EventArgs e)
      {
         Controller.LoadProfile();
         UpdateMappingStatistics();
      }

      private void buttonMainMerge_Click(object sender, EventArgs e)
      {
         Controller.MergeProfile();
         UpdateMappingStatistics();
      }

      private void buttonMainSetLed_Click(object sender, EventArgs e)
      {
         VLED.Engine.CalculateLEDs();
      }

      private void button1_Click_2(object sender, EventArgs e)
      {
         VLED.Engine.Query();
      }

      private void radioButton2_CheckedChanged(object sender, EventArgs e)
      {

      }

      private void buttonMainSaveProfile_Click(object sender, EventArgs e)
      {
         Controller.SaveProfile();
      }

      private void textBoxAircraft_TextChanged(object sender, EventArgs e)
      {

      }

      private void label1_Click_4(object sender, EventArgs e)
      {

      }

      private void TextBoxProfileName_TextChanged(object sender, EventArgs e)
      {

      }

      private void MenuItemSaveProfile_Click(object sender, EventArgs e)
      {
         Controller.SaveProfile();
      }

      private void MenuItemLoadProfile_Click(object sender, EventArgs e)
      {
         Controller.LoadProfile();
         UpdateMappingStatistics();
      }

      private void listViewData_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

      private void label1_Click_5(object sender, EventArgs e)
      {

      }

      private void button1_Click(object sender, EventArgs e)
      {

      }

      private void label1_Click_6(object sender, EventArgs e)
      {

      }

      private void label2_Click(object sender, EventArgs e)
      {

      }

      private void button1_Click_1(object sender, EventArgs e)
      {

      }

      private void buttonSettingsRemoveDevice_Click(object sender, EventArgs e)
      {
         foreach(int i in listViewSettingsDevices.SelectedIndices)
         {
            Controller.RemoveDevice(i);
         }
      }

      private void buttonSettingsCancel_Click(object sender, EventArgs e)
      {
         Controller.RestoreSettings();
      }

      private void buttonSettingsSave_Click(object sender, EventArgs e)
      {
         Controller.SaveSettings();
      }

      private void listViewSettingsDevices_SelectedIndexChanged(object sender, EventArgs e)
      {
         //UiController controller = VLED.Engine.GetUiController();

         if(listViewSettingsDevices.SelectedItems.Count==0)
         {
            buttonSettingsRemoveDevice.Enabled = false;
            buttonSettingsEditDevice.Enabled = false;
         }
         else
         {
            buttonSettingsRemoveDevice.Enabled = true;
            buttonSettingsEditDevice.Enabled = true;
         }

      }

      private void button101_Click(object sender, EventArgs e)
      {

      }


      private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

      private void checkBoxAutostart_CheckedChanged(object sender, EventArgs e)
      {
         if (!Controller.SettingsUpdating)
         {
            Controller.SetAutostartEndabled(checkBoxAutostartEnabled.Checked);
         }
      }

      private void label2_Click_1(object sender, EventArgs e)
      {

      }

      private void checkBox2_CheckedChanged(object sender, EventArgs e)
      {

      }

      private void buttonProfileUp_Click(object sender, EventArgs e)
      {
         if (this.listViewProfileEvents.SelectedItems.Count == 0) return;
         System.Windows.Forms.ListViewItem item = this.listViewProfileEvents.SelectedItems[0];
         int index = (int)item.Tag;
         int selected = this.listViewProfileEvents.SelectedIndices[0];
         if (index == 0 || selected == 0) return;
         // Profile changes
         Profile.ProfileEvent entry = VLED.Engine.CurrentProfile.ProfileEvents.ElementAt(index);
         VLED.Engine.CurrentProfile.ProfileEvents.RemoveAt(index);
         VLED.Engine.CurrentProfile.ProfileEvents.Insert(index - 1, entry);
         // List changes
         listViewProfileEvents.Items[selected].Tag = index - 1;
         listViewProfileEvents.Items[selected-1].Tag = index;
         listViewProfileEvents.Items.RemoveAt(selected);
         listViewProfileEvents.Items.Insert(selected - 1, item);
      }

      private void buttonProfileDown_Click(object sender, EventArgs e)
      {
         if (this.listViewProfileEvents.SelectedItems.Count == 0) return;
         System.Windows.Forms.ListViewItem item = this.listViewProfileEvents.SelectedItems[0];
         int index = (int)item.Tag;
         int selected = this.listViewProfileEvents.SelectedIndices[0];
         if (index == VLED.Engine.CurrentProfile.ProfileEvents.Count - 1 || selected == listViewProfileEvents.Items.Count) return;
         // Profile changes
         Profile.ProfileEvent entry = VLED.Engine.CurrentProfile.ProfileEvents.ElementAt(index);
         VLED.Engine.CurrentProfile.ProfileEvents.RemoveAt(index);
         VLED.Engine.CurrentProfile.ProfileEvents.Insert(index + 1, entry);
         // List changes
         listViewProfileEvents.Items[selected].Tag = index + 1;
         listViewProfileEvents.Items[selected + 1].Tag = index;
         listViewProfileEvents.Items.RemoveAt(selected);
         listViewProfileEvents.Items.Insert(selected + 1, item);
      }


      private void buttonProfileRemove_Click(object sender, EventArgs e)
      {
         if (this.listViewProfileEvents.SelectedItems.Count == 0) return;
         System.Windows.Forms.ListViewItem item = this.listViewProfileEvents.SelectedItems[0];
         int index = (int)item.Tag;
         int selected = this.listViewProfileEvents.SelectedIndices[0];
         // Profile changes
         VLED.Engine.CurrentProfile.ProfileEvents.RemoveAt(index);
         // List changes
         listViewProfileEvents.Items.RemoveAt(selected);
         for(int i=selected; i< listViewProfileEvents.Items.Count;i++)
         {
            listViewProfileEvents.Items[i].Tag = (int)listViewProfileEvents.Items[i].Tag - 1;
         }
      }

      private void buttonProfileDuplicate_Click(object sender, EventArgs e)
      {
         if (this.listViewProfileEvents.SelectedItems.Count == 0) return;
         System.Windows.Forms.ListViewItem item = this.listViewProfileEvents.SelectedItems[0];
         int index = (int)item.Tag;
         int selected = this.listViewProfileEvents.SelectedIndices[0];
         Loggable.LogDebug("DUPLICATE: index="+index+", selected="+selected);
         Profile.ProfileEvent entry = VLED.Engine.CurrentProfile.ProfileEvents.ElementAt(index);
         Profile.ProfileEvent duplicate = new Profile.ProfileEvent(entry);
         System.Windows.Forms.ListViewItem newItem = null;
         if (radioButtonNewElementsInsertAfter.Checked)
         {
            VLED.Engine.CurrentProfile.InsertProfileEvent(index+1, duplicate);
            newItem = listViewProfileEvents.Items.Insert(selected + 1, item.Text);
            newItem.Tag = index + 1;
            for(int i=selected + 2; i < listViewProfileEvents.Items.Count; i++)
            {
               listViewProfileEvents.Items[i].Tag = (int)listViewProfileEvents.Items[i].Tag + 1;
            }
         }
         else if(radioButtonNewElementsInsertBefore.Checked)
         {
            VLED.Engine.CurrentProfile.InsertProfileEvent(index,duplicate);
            newItem = listViewProfileEvents.Items.Insert(selected, item.Text);
            newItem.Tag = index;
            for (int i = selected + 1; i < listViewProfileEvents.Items.Count; i++)
            {
               listViewProfileEvents.Items[i].Tag = (int)listViewProfileEvents.Items[i].Tag + 1;
            }
         }
         else if (radioButtonNewElementsAppend.Checked)
         {
            VLED.Engine.CurrentProfile.AddProfileEvent(duplicate);
            newItem = listViewProfileEvents.Items.Add(item.Text);
            newItem.Tag = VLED.Engine.CurrentProfile.ProfileEvents.Count - 1;
         }
         //
         for (int i = 1; i < item.SubItems.Count; i++)
         {
            if(newItem!=null)
            {
               newItem.SubItems.Add(item.SubItems[i].Text);
            }
         }

      }


      private void buttonChooseDefaultProfile_Click(object sender, EventArgs e)
      {
         String path = Controller.ChooseDefaultProfile();
         if (path != null)
         {
            textBoxSettingsDefaultProfile.Text = path;
         }

      }

      private void textBoxSettingsUpdatenterval_TextChanged(object sender, EventArgs e)
      {
         if(!Controller.SettingsUpdating)
         {
            Controller.SetUpdateInterval(textBoxSettingsUpdateInterval.Text);
         }
      }

      private void textBoxSettingsFlashingCycles_TextChanged(object sender, EventArgs e)
      {
         if (!Controller.SettingsUpdating)
         {
            Controller.SetFlashingCycles(textBoxSettingsFlashingCycles.Text);
         }
      }

      private void textBoxSettingsDataInterval_TextChanged(object sender, EventArgs e)
      {
         if (!Controller.SettingsUpdating)
         {
            Controller.SetDataInterval(textBoxSettingsDataInterval.Text);
         }
      }

      private void buttonSettingsEditDevice_Click(object sender, EventArgs e)
      {
         if (listViewSettingsDevices.SelectedIndices.Count == 0) return;
         Controller.EditDevice(listViewSettingsDevices.SelectedIndices[0]);

      }

      private void buttonSettingsAddDevice_Click(object sender, EventArgs e)
      {
         Controller.AddNewDevice();
      }

      private void comboBoxLogLevel_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (!Controller.SettingsUpdating)
         {
            String level = (String)comboBoxLogLevel.SelectedItem;
            switch (level)
            {
               case "OFF":
                  Controller.SetSettingsLogLevel(Loggable.LEVEL.OFF);
                  break;
               case "ERROR":
                  Controller.SetSettingsLogLevel(Loggable.LEVEL.ERROR);
                  break;
               case "WARNING":
                  Controller.SetSettingsLogLevel(Loggable.LEVEL.WARNING);
                  break;
               case "INFO":
                  Controller.SetSettingsLogLevel(Loggable.LEVEL.INFO);
                  break;
               case "DEBUG":
                  Controller.SetSettingsLogLevel(Loggable.LEVEL.DEBUG);
                  break;
               case "TRACE":
                  Controller.SetSettingsLogLevel(Loggable.LEVEL.TRACE);
                  break;
            }
         }
      }

      private void buttonProfileAdd_Click(object sender, EventArgs e)
      {
         Controller.AddNewProfileEvent();
      }

      private void buttonProfileEdit_Click(object sender, EventArgs e)
      {
         if (this.listViewProfileEvents.SelectedItems.Count == 0) return;
         Controller.EditProfileEvent();
      }

      private void listView1_SelectedIndexChanged(object sender, EventArgs e)
      {

         if (listViewMapping.SelectedIndices.Count == 0)
         {
            buttonMappingRemove.Enabled = false;
            buttonMappingEdit.Enabled = false;
         }
         else
         {
            buttonMappingRemove.Enabled = true;
            buttonMappingEdit.Enabled = true;
         }
      }

      private void buttonMappingAdd_Click(object sender, EventArgs e)
      {
         Controller.AddNewMapping();
         UpdateMappingStatistics();
      }

      private void buttonMappingRemove_Click(object sender, EventArgs e)
      {
         if (this.listViewMapping.SelectedIndices.Count == 0) return;
         int index = this.listViewMapping.SelectedIndices[0];

         Controller.RemoveMapping(index);
         UpdateMappingStatistics();
      }

      private void buttonMappingEdit_Click(object sender, EventArgs e)
      {
         if (this.listViewMapping.SelectedIndices.Count == 0) return;
         int index = this.listViewMapping.SelectedIndices[0];

         Controller.EditMapping(index);

      }

      private void button1_Click_3(object sender, EventArgs e)
      {
         ColorChooserDialog d = new ColorChooserDialog();
         d.ShowDialog();
      }

      private void installExportScrriptsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         VLED.ShowInstallScriptsDialog(false);
      }

      private void panel2_Paint(object sender, PaintEventArgs e)
      {

      }

      private void removeExportScriptsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (MessageBox.Show("Are you sure to remove all export scripts?", "Remove Export Scripts from DCS",MessageBoxButtons.YesNo) == DialogResult.Yes)
         {
            String userprofile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            Tools.UninstallDcsScripts(userprofile + "\\" + "Saved Games" + "\\DCS");
            Tools.UninstallDcsScripts(userprofile + "\\" + "Saved Games" + "\\DCS.openbeta");
         }
      }

      private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         String about = "- VLEDCONTROL -";
         about += "\n\n";
         about += VLED.Version;
         about += "\n\n";
         about += "Written by André Kolster";
         about += "\n\n\n";
         about += "Apache 2.0 License";
         about += "\n";
         about += "(see LICENSE file)";

         about += "\n\n\nSource: https://github.com/Nereid42/VLEDCONTROL";

         MessageBox.Show(about, "About", MessageBoxButtons.OK);
      }

      private void buttonProfilesClear_Click(object sender, EventArgs e)
      {
         if(MessageBox.Show("Are you sure to delete all profile events", "Clear Profile", MessageBoxButtons.YesNo) == DialogResult.Yes)
         {
            VLED.Engine.CurrentProfile.ClearProfileEvents();
            this.listViewProfileEvents.Items.Clear();
            UpdateMappingStatistics();
         }
      }

      private void buttonCopyAircraftToClipboard_Click(object sender, EventArgs e)
      {
         Clipboard.SetText(this.textBoxAircraft.Text);
      }

      private void checkBoxEnableStatistics_CheckedChanged(object sender, EventArgs e)
      {
         Controller.SetStatisticsEnabled(this.checkBoxEnableStatistics.Checked);
      }

      private void checkBoxLiveDataEnabled_CheckedChanged(object sender, EventArgs e)
      {
         bool enabled = this.checkBoxLiveDataEnabled.Checked;
         VLED.Engine.CurrentSettings.LiveDataEnabled = enabled;
         if (enabled)
         {
            VLED.Engine.ShowProperties();
         }
      }

      private void comboBoxProfileFilterAircraft_SelectedIndexChanged(object sender, EventArgs e)
      {
         Controller.SetProfile(VLED.Engine.CurrentProfile);
      }

      private void comboBoxProfileFilterDevice_SelectedIndexChanged(object sender, EventArgs e)
      {
         Controller.SetProfile(VLED.Engine.CurrentProfile);
      }


      private void checkBoxFilterStatic_CheckedChanged(object sender, EventArgs e)
      {
         Controller.SetProfile(VLED.Engine.CurrentProfile);
      }

      private void comboBoxMappingFilterAircraft_SelectedIndexChanged(object sender, EventArgs e)
      {
         Controller.SetProfile(VLED.Engine.CurrentProfile);
      }

      private void buttonImportFromProfile_Click(object sender, EventArgs e)
      {
         Controller.ImportMappingFromProfile();
         UpdateMappingStatistics();
      }

      private void checkBoxDataShowUnknown_CheckedChanged(object sender, EventArgs e)
      {
         listViewData.Items.Clear();
         Controller.MarkDataAsDirty(true);
      }

      private void buttonQuickAdd_Click(object sender, EventArgs e)
      {

         Controller.AddQuickProfileEvent();
      }

      private void buttonMainResetLed_Click_4(object sender, EventArgs e)
      {
         VLED.Engine.ResetAllDeviceLeds();
      }

      private void checkBoxData10Only_CheckedChanged(object sender, EventArgs e)
      {
         listViewData.Items.Clear();
         Controller.MarkDataAsDirty(true);
      }

      private void buttonCurrentAircraft_Click(object sender, EventArgs e)
      {
         this.comboBoxMappingFilterAircraft.Text = this.textBoxAircraft.Text;
         Controller.SetProfile(VLED.Engine.CurrentProfile);
      }

      private void button1_Click_4(object sender, EventArgs e)
      {
         this.comboBoxProfileFilterAircraft.Text = this.textBoxAircraft.Text;
         Controller.SetProfile(VLED.Engine.CurrentProfile);
      }

      private void checkBoxHighlightLed_CheckedChanged(object sender, EventArgs e)
      {
         VLED.Engine.CurrentSettings.HighlightLedEnabled = checkBoxHighlightLed.Checked;
      }

      private void buttonEnable_Click(object sender, EventArgs e)
      {
         bool enabled = Controller.EnableProfileEvent(buttonProfileEnable.Text.Equals("Enable"));

         buttonProfileEnable.Text = enabled ? "Disable" : "Enable";
      }

      private void listViewIdLimit_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

      private void copyDefaultProfileMappingToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Tools.CopyDefaultProfileMapping();
      }
   }
}
