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
   public partial class MainWindowForm : Form
   {
      public readonly UiController Controller;

      public MainWindowForm()
      {
         InitializeComponent();
         Controller = new UiController(this);
         this.comboBoxLogLevel.KeyPress += new KeyPressEventHandler(LogLevelComboBoxKeyPressed);
         this.listViewMapping.ListViewItemSorter = new NumericListViewSorter();
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
         // check if VpcLedControlExe is set
         if(VLED.Engine.CurrentSettings.VirpilLedControl==null || VLED.Engine.CurrentSettings.VirpilLedControl.Length==0)
         {
            VLED.ShowVpcLedControlSetupDialog();
         }

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
         }
         else
         {
            buttonProfileRemove.Enabled = true;
            buttonProfileDuplicate.Enabled = true;
            buttonProfileEdit.Enabled = true;
            buttonProfileDown.Enabled = ( listViewProfileEvents.SelectedIndices[0] < listViewProfileEvents.Items.Count - 1 );
            buttonProfileUp.Enabled = ( listViewProfileEvents.SelectedIndices[0] > 0 );
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
      }

      private void buttonMainSetLed_Click(object sender, EventArgs e)
      {

      }

      private void button1_Click_2(object sender, EventArgs e)
      {

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

      private void setLEDCOntrolToolStripMenuItem_Click(object sender, EventArgs e)
      {
         String path = Controller.ChooseVirpilLedControl();
         if (path != null)
         {
            textBoxSettingsVirpilLedControl.Text = path;
         }
      }

      private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

      private void checkBoxAutostart_CheckedChanged(object sender, EventArgs e)
      {

      }

      private void label2_Click_1(object sender, EventArgs e)
      {

      }

      private void checkBox2_CheckedChanged(object sender, EventArgs e)
      {

      }

      private void buttonProfileUp_Click(object sender, EventArgs e)
      {
         if (listViewProfileEvents.SelectedIndices.Count == 0) return;
         int index = listViewProfileEvents.SelectedIndices[0];
         if (index == 0) return;
         Profile.ProfileEvent entry = VLED.Engine.CurrentProfile.ProfileEvents.ElementAt(index);
         Controller.Log("entry=" + entry);
         VLED.Engine.CurrentProfile.ProfileEvents.RemoveAt(index);
         VLED.Engine.CurrentProfile.ProfileEvents.Insert(index - 1, entry);
         System.Windows.Forms.ListViewItem item = listViewProfileEvents.Items[index];
         listViewProfileEvents.Items.RemoveAt(index);
         listViewProfileEvents.Items.Insert(index - 1, item);
      }

      private void buttonProfileDown_Click(object sender, EventArgs e)
      {
         if (listViewProfileEvents.SelectedIndices.Count == 0) return;
         int index = listViewProfileEvents.SelectedIndices[0];
         if (index == listViewProfileEvents.Items.Count - 1) return;
         Profile.ProfileEvent entry = VLED.Engine.CurrentProfile.ProfileEvents.ElementAt(index);
         Controller.Log("entry=" + entry);
         VLED.Engine.CurrentProfile.ProfileEvents.RemoveAt(index);
         VLED.Engine.CurrentProfile.ProfileEvents.Insert(index + 1, entry);
         System.Windows.Forms.ListViewItem item = listViewProfileEvents.Items[index];
         listViewProfileEvents.Items.RemoveAt(index);
         listViewProfileEvents.Items.Insert(index + 1, item);
      }

      private void buttonProfileRemove_Click(object sender, EventArgs e)
      {
         if (listViewProfileEvents.SelectedIndices.Count == 0) return;
         int index = listViewProfileEvents.SelectedIndices[0];
         VLED.Engine.CurrentProfile.ProfileEvents.RemoveAt(index);
         listViewProfileEvents.Items.RemoveAt(index);
      }

      private void buttonProfileDuplicate_Click(object sender, EventArgs e)
      {
         if (listViewProfileEvents.SelectedIndices.Count == 0) return;
         int index = listViewProfileEvents.SelectedIndices[0];
         Profile.ProfileEvent entry = VLED.Engine.CurrentProfile.ProfileEvents.ElementAt(index);
         System.Windows.Forms.ListViewItem item = listViewProfileEvents.Items[index];
         Profile.ProfileEvent duplicate = new Profile.ProfileEvent(entry);
         System.Windows.Forms.ListViewItem newItem = null;
         if (radioButtonNewElementsInsertAfter.Checked)
         {
            VLED.Engine.CurrentProfile.InsertProfileEntry(index+1, duplicate);
            newItem = listViewProfileEvents.Items.Insert(index + 1, item.Text);
         }
         else if(radioButtonNewElementsInsertBefore.Checked)
         {
            VLED.Engine.CurrentProfile.InsertProfileEntry(index,duplicate);
            newItem = listViewProfileEvents.Items.Insert(index, item.Text);
         }
         else if (radioButtonNewElementsAppend.Checked)
         {
            VLED.Engine.CurrentProfile.AddProfileEntry(duplicate);
            newItem = listViewProfileEvents.Items.Add(item.Text);
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

      private void buttonChooseVirpilLedControl_Click(object sender, EventArgs e)
      {
         String path = Controller.ChooseVirpilLedControl();
         if(path!=null)
         {
            textBoxSettingsVirpilLedControl.Text = path;
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
            Controller.SetSettingsModified(true);
         }
      }

      private void textBoxSettingsFlashingCycles_TextChanged(object sender, EventArgs e)
      {
         if (!Controller.SettingsUpdating)
         {
            Controller.SetFlashingCycles(textBoxSettingsFlashingCycles.Text);
            Controller.SetSettingsModified(true);
         }
      }

      private void textBoxSettingsDataInterval_TextChanged(object sender, EventArgs e)
      {
         if (!Controller.SettingsUpdating)
         {
            Controller.SetDataInterval(textBoxSettingsDataInterval.Text);
            Controller.SetSettingsModified(true);
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
         if (this.listViewProfileEvents.SelectedIndices.Count == 0) return;
         int index = this.listViewProfileEvents.SelectedIndices[0];
         Controller.EditProfileEvent(index);
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
      }

      private void buttonMappingRemove_Click(object sender, EventArgs e)
      {
         if (this.listViewMapping.SelectedIndices.Count == 0) return;
         int index = this.listViewMapping.SelectedIndices[0];

         Controller.RemoveMapping(index);
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
            Tools.RemoveDcsScripts(userprofile + "\\" + "Saved Games" + "\\DCS");
            Tools.RemoveDcsScripts(userprofile + "\\" + "Saved Games" + "\\DCS.openbeta");
         }
      }

      private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         String about = "- VLEDCONTROL -";
         about += "\n\n";
         about += "Written by André Kolster";
         about += "\n\n\n";
         about += "MIT License";
         about += "\n";
         about += "\nPermission is hereby granted, free of charge, to any person obtaining a ";
         about += "\ncopy of this software and associated documentation files (the";
         about += "\n\"Software\"), to deal in the Software without restriction, including";
         about += "\nwithout limitation the rights to use, copy, modify, merge, publish,";
         about += "\ndistribute, sublicense, and/ or sell copies of the Software, and to permit";
         about += "\npersons to whom the Software is furnished to do so, subject to the following conditions:\n";

         about += "\nThe above copyright notice and this permission notice shall be included";
         about += "\nin all copies or substantial portions of the Software.";

         MessageBox.Show(about, "About", MessageBoxButtons.OK);
      }
   }
}
