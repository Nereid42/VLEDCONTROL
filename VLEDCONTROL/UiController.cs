﻿/* written 2021 by Nereid
  
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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace VLEDCONTROL
{
   public class UiController : Loggable
   {
      public const String NO_AIRCRAFT = "- NO AIRCRAFT -";

      private const String PROFILE_FILTER_ANY_AIRCAFT = "ANY";
      private const String PROFILE_FILTER_ANY_DEVICE = "ANY";

      private readonly MainWindowForm MainWindow;
      private readonly Settings DisplayedSettings = new Settings();

      private volatile bool _IsDataDirty = false;

      public bool SettingsUpdating { get; private set; } = false;
      public bool IsDataDirty { get { return _IsDataDirty; } set { _IsDataDirty = value; } }

      private volatile bool IsAdjusting = false;

      public UiController(MainWindowForm mainWindow)
      {
         MainWindow = mainWindow;
         MainWindow.listViewData.Items.Clear();
      }

      public void Clear()
      {
         SetAircraftName(null);
      }

      public bool IsHandleCreated()
      {
         return MainWindow.IsHandleCreated;
      }

      private void SetTextBoxText(System.Windows.Forms.TextBox textBox, String text )
      {
         SetTextBoxText(textBox, text, true);
      }


      private void SetTextBoxText(System.Windows.Forms.TextBox textBox, String text, bool async)
      {
         try
         {
            if(async)
            {
               textBox.BeginInvoke(
                  new Action(() => textBox.Text = text)
                  );
            }
            else
            {
               textBox.Invoke(
                  new Action(() => textBox.Text = text)
                  );
            }
         }
         catch (Exception e)
         {
            LogException(e);
         }
      }


      private void SetControlEnabled(System.Windows.Forms.Control control, bool enabled)
      {
         try
         {
            control.BeginInvoke(
               new Action(() => control.Enabled = enabled)
               );
         }
         catch (Exception e)
         {
            LogException(e);
         }
      }

      private void SetCheckBoxChecked(System.Windows.Forms.CheckBox checkBox, bool state)
      {
         try
         {
            checkBox.Invoke(
               new Action(() => checkBox.Checked = state)
               );
         }
         catch (Exception e)
         {
            LogException(e);
         }
      }


      public void SetData(int id, String name, double value, DateTime lastChange)
      {
         if (MainWindow.IsHandleCreated)
         {
            if( (MainWindow.checkBoxDataShowUnknown.Checked || ( name != null && name.Length>0))
            && (!MainWindow.checkBoxData10Only.Checked || value==1.0 || value==0.0) )
            {
               MainWindow.listViewData.BeginInvoke(
                  new Action(() =>
                  {
                     string sid = id.ToString("0000");
                     System.Windows.Forms.ListViewItem[] items = MainWindow.listViewData.Items.Find(sid, false);
                     if (items == null || items.Length == 0)
                     {
                        System.Windows.Forms.ListViewItem item = MainWindow.listViewData.Items.Add(sid);
                        item.Name = sid;
                        item.SubItems.Add(name);
                        item.SubItems.Add(value.ToString("0.00000000"));
                        item.SubItems.Add(lastChange.ToString("T"));
                     }
                     else
                     {
                        items[0].SubItems[1].Text = name;
                        items[0].SubItems[2].Text = value.ToString("0.00000000");
                        items[0].SubItems[3].Text = lastChange.ToString("T");
                     }
                  })
               );
            }
         }
      }



      public void MarkDataAsDirty(bool dirty)
      {
         IsDataDirty = dirty;
      }


      internal void ClearData()
      {
         MainWindow.listViewData.BeginInvoke(
            new Action(() =>
            {
               MainWindow.listViewData.Items.Clear();
            })
         );
      }

      internal void StartStopEngine()
      {
         if(!this.IsAdjusting)
         {
            Engine engine = VLED.Engine;
            if (engine.IsRunning)
            {
               VLED.Engine.Stop();
            }
            else
            {
               VLED.Engine.Start();
            }
         }
      }

      internal void SetEngineStarted(bool started)
      {
         this.IsAdjusting = true;
         try
         {
            if (started)
            {
               LogInfo("Set Engine started in UI");
               MainWindow.BeginInvoke(
                  new Action(() =>
                  {
                     MainWindow.buttonMainStart.BackColor = System.Drawing.Color.GreenYellow;
                     MainWindow.buttonMainStart.Text = "STOP";
                     MainWindow.progressBarEngineStatus.MarqueeAnimationSpeed = 40;
                  })
               );
            }
            else
            {
               LogInfo("Set Engine stopped in UI");
               MainWindow.BeginInvoke(
                  new Action(() =>
                  {
                     MainWindow.buttonMainStart.BackColor = System.Drawing.Color.Coral;
                     MainWindow.buttonMainStart.Text = "START";
                     MainWindow.progressBarEngineStatus.MarqueeAnimationSpeed = 0;
                     MainWindow.progressBarEngineStatus.Value = 0;
                  })
               );
            }
         }
         finally
         {
            this.IsAdjusting = false;
         }
      }


      internal void LoadProfile()
      {
         using (OpenFileDialog chooser = new OpenFileDialog())
         {
            chooser.InitialDirectory = Tools.GetApplicationFolder();
            chooser.Multiselect = false;
            chooser.Filter = "Profile files (*.profile)|*.profile";
            chooser.FilterIndex = 1;
            chooser.RestoreDirectory = true;
            if (chooser.ShowDialog() == DialogResult.OK)
            {
               VLED.Engine.CurrentProfile = Profile.Load(chooser.FileName);
               SetProfile(VLED.Engine.CurrentProfile);
               SetProfileFilter(VLED.Engine.CurrentProfile);
               // show profile tab
               MainWindow.tabMain.SelectTab(1);
            }
         }
      }

      internal void MergeProfile()
      {
         using (OpenFileDialog chooser = new OpenFileDialog())
         {
            chooser.InitialDirectory = Tools.GetApplicationFolder();
            chooser.Multiselect = false;
            chooser.Filter = "Profile files (*.profile)|*.profile";
            chooser.FilterIndex = 1;
            chooser.RestoreDirectory = true;
            if (chooser.ShowDialog() == DialogResult.OK)
            {
               Profile profile = Profile.Load(chooser.FileName);
               VLED.Engine.CurrentProfile.Merge(profile);
               SetProfile(VLED.Engine.CurrentProfile);
               SetProfileFilter(VLED.Engine.CurrentProfile);
               // show profile tab
               MainWindow.tabMain.SelectTab(1);
            }
         }
      }

      internal void SaveProfile()
      {
         using (SaveFileDialog chooser = new SaveFileDialog())
         {

            chooser.InitialDirectory = Tools.GetApplicationFolder();
            chooser.Filter = "Profile files (*.profile)|*.profile";
            chooser.FilterIndex = 1;
            chooser.RestoreDirectory = true;
            if (chooser.ShowDialog() == DialogResult.OK)
            {
               String path = chooser.FileName;
               String name = Path.GetFileName(path); ;
               int p = name.LastIndexOf('.');
               if(p>=0)
               {
                  name = name.Remove(p);
               }
               VLED.Engine.CurrentProfile.Name = name;
               VLED.Engine.CurrentProfile.SaveAs(path);
            }

         }
      }

      internal void SetAutostartEndabled(bool enabled)
      {
         DisplayedSettings.AutostartEnabled = enabled;
         SetSettingsModified(true);
      }

      internal void ImportMappingFromProfile()
      {
         using (OpenFileDialog chooser = new OpenFileDialog())
         {

            chooser.InitialDirectory = Tools.GetApplicationFolder();
            chooser.Multiselect = false;
            chooser.Filter = "Profile files (*.profile)|*.profile";
            chooser.FilterIndex = 1;
            chooser.RestoreDirectory = true;
            if (chooser.ShowDialog() == DialogResult.OK)
            {
               Profile profile = Profile.Load(chooser.FileName);
               VLED.Engine.CurrentProfile.ImportMapping(profile);
               SetProfile(VLED.Engine.CurrentProfile);
               SetProfileFilter(VLED.Engine.CurrentProfile);
            }
         }
      }

      public void SetSettings(Settings settings)
      {
         SetSettings(settings, false);
      }

      public void SetSettings(Settings settings, bool modified)
      {
         LogDebug("Set Displayed Settings...");
         SettingsUpdating = true;
         DisplayedSettings.CopySettings(settings);

         SetTextBoxText(MainWindow.textBoxSettingsDefaultProfile, settings.DefaultProfile, false);
         // Intervals
         SetTextBoxText(MainWindow.textBoxSettingsDataInterval, settings.DataInterval.ToString("N2"), false);
         SetTextBoxText(MainWindow.textBoxSettingsUpdateInterval, settings.UpdateInterval.ToString("N2"), false);
         SetTextBoxText(MainWindow.textBoxSettingsFlashingCycles, settings.FlashingCycles.ToString(), false);
         // Devices
         MainWindow.listViewSettingsDevices.Invoke(
            new Action(() =>
            {
               MainWindow.listViewSettingsDevices.Items.Clear();
               int id = 0;
               foreach (VirpilDevice device in settings.Devices)
               {
                  LogDebug("Displayed Stetings Add Virpil Device "+device);
                  System.Windows.Forms.ListViewItem item = MainWindow.listViewSettingsDevices.Items.Add(id.ToString());
                  item.SubItems.Add(device.Name);
                  item.SubItems.Add(device.USB_VID);
                  item.SubItems.Add(device.USB_PID);
                  id++;
               }
            })
         );

         // Checkboxes
         SetCheckBoxChecked(MainWindow.checkBoxEnableStatistics, settings.StatisticsEnabled);
         SetCheckBoxChecked(MainWindow.checkBoxLiveDataEnabled, settings.LiveDataEnabled);
         SetCheckBoxChecked(MainWindow.checkBoxAutostartEnabled, settings.AutostartEnabled);
         SetCheckBoxChecked(MainWindow.checkBoxHighlightLed, settings.HighlightLedEnabled);

         // Buttons
         SetSettingsModified(modified);
         SetSettingsLogLevel(DisplayedSettings.LogLevel);
         SettingsUpdating = false;
      }

      public void SetUpdateInterval(double interval)
      {
         SettingsUpdating = true;
         DisplayedSettings.UpdateInterval = interval;
         SetTextBoxText(MainWindow.textBoxSettingsUpdateInterval, interval.ToString(), false);
         SettingsUpdating = false;
      }

      public void SetUpdateInterval(String interval)
      {
         SettingsUpdating = true;
         try
         {
            DisplayedSettings.UpdateInterval = double.Parse(interval);
            SetSettingsModified(true);
         }
         catch { /* nothing */  }
         SetTextBoxText(MainWindow.textBoxSettingsUpdateInterval, interval.ToString(), false);
         SettingsUpdating = false;
      }

      public void SetFlashingCycles(int cycles)
      {
         SettingsUpdating = true;
         DisplayedSettings.FlashingCycles = cycles;
         SetTextBoxText(MainWindow.textBoxSettingsFlashingCycles, cycles.ToString(), false);
         SettingsUpdating = false;
      }

      public void SetFlashingCycles(String cycles)
      {
         SettingsUpdating = true;
         try
         {
            DisplayedSettings.FlashingCycles = int.Parse(cycles);
            SetSettingsModified(true);
         }
         catch { /* nothing */  }
         SetTextBoxText(MainWindow.textBoxSettingsFlashingCycles, cycles.ToString(), false);
         SettingsUpdating = false;
      }

      public void SetDataInterval(double interval)
      {
         SettingsUpdating = true;
         DisplayedSettings.DataInterval = interval;
         SetTextBoxText(MainWindow.textBoxSettingsDataInterval, interval.ToString(), false);
         SettingsUpdating = false;
      }

      public void SetDataInterval(String interval)
      {
         SettingsUpdating = true;
         try
         {
            DisplayedSettings.DataInterval = double.Parse(interval);
            SetSettingsModified(true);
         }
         catch { /* nothing */  }
         SetTextBoxText(MainWindow.textBoxSettingsDataInterval, interval.ToString(), false);
         SettingsUpdating = false;
      }

      public void SetStatisticsEnabled(bool enabled)
      {
         SettingsUpdating = true;
         this.DisplayedSettings.StatisticsEnabled = enabled;
         MainWindow.checkBoxEnableStatistics.Checked = enabled;
         SetSettingsModified(true);
         SettingsUpdating = false;
      }

      public void SetProfile(Profile profile)
      {
         MainWindow.listViewProfileEvents.Invoke(
            new Action(() =>
            {
               MainWindow.listViewProfileEvents.Items.Clear();
               for(int index = 0; index < profile.ProfileEvents.Count; index++)               
               {
                  Profile.ProfileEvent entry = profile.ProfileEvents.ElementAt(index);
                  if (ProfileFilterAccepted(entry))
                  {
                     System.Windows.Forms.ListViewItem item = MainWindow.listViewProfileEvents.Items.Add(entry.Id.ToString());
                     item.Tag = index;
                     item.BackColor = System.Drawing.Color.Empty;
                     item.SubItems.Add(entry.Aircraft);
                     item.SubItems.Add(profile.MapPropertyName(entry.Aircraft, entry.Id));
                     item.SubItems.Add(entry.GetConditionsAsString());
                     item.SubItems.Add(entry.DeviceId.ToString());
                     item.SubItems.Add(entry.LedNumber.ToString());
                     item.SubItems.Add(entry.ColorOn.AsString());
                     item.SubItems.Add(entry.ColorFlashing.AsString());
                     item.SubItems.Add(Tools.EnabledToYesNo(entry.Enabled));
                     item.SubItems.Add(entry.Description);
                  }
               }

               MainWindow.listViewMapping.Items.Clear();
               foreach (Profile.MappingEntry entry in profile.MappingEntries)
               {
                  if (MappingFilterAccepted(entry))
                  {
                     System.Windows.Forms.ListViewItem item = MainWindow.listViewMapping.Items.Add(entry.Id.ToString());
                     item.SubItems.Add(entry.Aircraft);
                     item.SubItems.Add(entry.Name);
                  }
               }
               MainWindow.listViewMapping.Sort();
            })
         );
         SetTextBoxText(MainWindow.textBoxProfileName, profile.Name);
         SetTextBoxText(MainWindow.textBoxMappingProfileName, profile.Name);
         //
         MainWindow.UpdateButtonStates();
      }

      private bool ProfileFilterAccepted(Profile.ProfileEvent entry)
      {
         if (!MainWindow.checkBoxProfileFilterStatic.Checked && entry.IsStatic()) return false;
         if (!MainWindow.checkBoxProfileFilterDisabled.Checked && !entry.Enabled) return false;
         if (!MainWindow.comboBoxProfileFilterAircraft.Text.Equals(PROFILE_FILTER_ANY_AIRCAFT) && !MainWindow.comboBoxProfileFilterAircraft.Text.Equals(entry.Aircraft)) return false;
         int id = Tools.IndexOfSelectedComboBoxItem(MainWindow.comboBoxProfileFilterDevice) - 1;
         if (id >= 0)
         {
            return entry.DeviceId == id;
         }

         return true;
      }

      private bool MappingFilterAccepted(Profile.MappingEntry entry)
      {
         if (!MainWindow.comboBoxMappingFilterAircraft.Text.Equals(PROFILE_FILTER_ANY_AIRCAFT) && !MainWindow.comboBoxMappingFilterAircraft.Text.Equals(entry.Aircraft)) return false;
         return true;
      }

      public void DisplayStatistics (long totalRuntime, long ledCalcTime, long ledChanges)
      {
         if (IsLoggable(LEVEL.TRACE)) LogTrace("Statistics: totalRuntime=" + totalRuntime + ", ledCalcTime=" + ledCalcTime + ", ledChanges=" + ledChanges);
         SetTextBoxText(MainWindow.textBoxTimeRunning, totalRuntime.ToString());
         SetTextBoxText(MainWindow.textBoxTimeUsedLedCalc, ledCalcTime.ToString());
         SetTextBoxText(MainWindow.textBoxNumberLedChanges, ledChanges.ToString());
         double runtimePct = totalRuntime!=0 ? 100.0 * (double)ledCalcTime / (double)totalRuntime : 0.0;
         double ledChangesPerSecond = totalRuntime != 0 ? 1000.0 * (double) ledChanges / (double)totalRuntime : 0.0;
         SetTextBoxText(MainWindow.textBoxTimeUsedLedCalcPercent, Tools.ToString(runtimePct));
         SetTextBoxText(MainWindow.textBoxNumberLedChangesPerSecond, Tools.ToString(ledChangesPerSecond));
      }

      public void Log(String msg)
      {
         LogError(msg);
      }


      internal void RestoreSettings()
      {
         SetSettings(VLED.Engine.CurrentSettings);
         SetSettingsModified(false);
      }

      internal void SaveSettings()
      {
         VLED.Engine.CurrentSettings.CopySettings(DisplayedSettings);
         SetLogLevel(VLED.Engine.CurrentSettings.LogLevel);
         SetSettingsModified(false);
         VLED.Engine.CurrentSettings.SaveAsync();
         SetSettingsLogLevel(VLED.Engine.CurrentSettings.LogLevel);
         VLED.Engine.CommitDataUpdate();
      }

      internal void RemoveDevice(int deviceId)
      {
         if(deviceId <DisplayedSettings.Devices.Count)
         {
            DisplayedSettings.Devices.RemoveAt(deviceId);
            MainWindow.listViewSettingsDevices.BeginInvoke(
            new Action(() =>
               {
                  MainWindow.listViewSettingsDevices.Items.RemoveAt(deviceId);
                  for(int i= deviceId; i< MainWindow.listViewSettingsDevices.Items.Count; i++)
                  {
                     MainWindow.listViewSettingsDevices.Items[i].Text = i.ToString();
                  }
               })
            );
            SetSettingsModified(true);
         }

      }

      internal void AddNewDevice()
      {
         EditDeviceDialog dialog = new EditDeviceDialog() { Id = MainWindow.listViewSettingsDevices.Items.Count };
         if (dialog.ShowDialog() == DialogResult.OK)
         {
            String name = dialog.GetDeviceName();
            String vid = dialog.GetUsbVid();
            String pid = dialog.GetUsbPid();
            VirpilDevice device = new VirpilDevice(name, vid, pid);
            DisplayedSettings.AddDevice(device);
            MainWindow.listViewSettingsDevices.BeginInvoke(
            new Action(() =>
            {
               System.Windows.Forms.ListViewItem item = MainWindow.listViewSettingsDevices.Items.Add(MainWindow.listViewSettingsDevices.Items.Count.ToString());
               item.SubItems.Add(device.Name);
               item.SubItems.Add(device.USB_VID);
               item.SubItems.Add(device.USB_PID);
            })
            );
            SetSettingsModified(true);
         }
      }

      internal void EditDevice(int id)
      {
         VirpilDevice device = DisplayedSettings.GetDevice(id);
         EditDeviceDialog dialog = new EditDeviceDialog();
         dialog.Id = id;
         dialog.Device = device;
         if (dialog.ShowDialog() == DialogResult.OK)
         {
            device.Name = dialog.GetDeviceName();
            device.SetVID( dialog.GetUsbVid() );
            device.SetPID( dialog.GetUsbPid() );
            MainWindow.listViewSettingsDevices.BeginInvoke(
            new Action(() =>
            {
               System.Windows.Forms.ListViewItem item = MainWindow.listViewSettingsDevices.Items[id];
               item.SubItems[1].Text = device.Name;
               item.SubItems[2].Text = device.USB_VID;
               item.SubItems[3].Text = device.USB_PID;
               // move device?
               int newid = dialog.GetDeviceId();
               if( newid != id)
               {
                  int maxid = MainWindow.listViewSettingsDevices.Items.Count - 1;
                  if (newid > maxid )
                  {
                     newid = maxid;
                  }
                  MainWindow.listViewSettingsDevices.Items.RemoveAt(id);
                  DisplayedSettings.RemoveDevice(id);
                  MainWindow.listViewSettingsDevices.Items.Insert(newid,item);
                  DisplayedSettings.InsertDevice(newid, device);
                  for(int i=0; i< MainWindow.listViewSettingsDevices.Items.Count; i++)
                  {
                     MainWindow.listViewSettingsDevices.Items[i].Text = i.ToString();
                  }
               }
            })
            );

            SetSettingsModified(true);
         }
      }


      internal void RemoveMapping(int index)
      {
         System.Windows.Forms.ListViewItem item = MainWindow.listViewMapping.Items[index];
         int id = Tools.ToInt(item.Text);
         String aircraft = item.SubItems[1].Text;

         VLED.Engine.CurrentProfile.RemoveMapping(aircraft,id);
         MainWindow.listViewMapping.BeginInvoke(
         new Action(() =>
         {
            MainWindow.listViewMapping.Items.RemoveAt(index);
         })
         );
      }

      internal void AddNewMapping()
      {
         EditMappingEntryDialog dialog = new EditMappingEntryDialog() { Profile = VLED.Engine.CurrentProfile };

         if (dialog.ShowDialog() == DialogResult.OK)
         {
            String aircraft = dialog.GetAircraft();
            int id = dialog.GetId();
            if(!VLED.Engine.CurrentProfile.ContainsMapping(aircraft,id))
            {
               String name = dialog.GetName();
               VLED.Engine.CurrentProfile.AddMapping(aircraft, id, name);
               MainWindow.listViewMapping.BeginInvoke(
               new Action(() =>
               {
                  System.Windows.Forms.ListViewItem item = MainWindow.listViewMapping.Items.Add(id.ToString());
                  item.SubItems.Add(aircraft);
                  item.SubItems.Add(name);
               })
               );
            }
            UpdateProfileFilter(VLED.Engine.CurrentProfile);
         }
      }

      internal void ClearProfileFilter()
      {
         MainWindow.checkBoxProfileFilterStatic.Checked = true;
         MainWindow.comboBoxProfileFilterAircraft.Text = PROFILE_FILTER_ANY_AIRCAFT;
         MainWindow.comboBoxProfileFilterDevice.Text = PROFILE_FILTER_ANY_DEVICE;
         MainWindow.comboBoxProfileFilterAircraft.Items.Clear();
         MainWindow.comboBoxProfileFilterDevice.Items.Clear();
         //
         MainWindow.comboBoxMappingFilterAircraft.Text = PROFILE_FILTER_ANY_AIRCAFT;
         MainWindow.comboBoxMappingFilterAircraft.Items.Clear();
         SetProfile(VLED.Engine.CurrentProfile);
      }

      internal void SetProfileFilter(Profile profile)
      {
         ClearProfileFilter();
         UpdateProfileFilter(profile);
      }

      internal void UpdateProfileFilter(Profile profile)
      {
         MainWindow.comboBoxProfileFilterAircraft.Items.Clear();
         MainWindow.comboBoxProfileFilterDevice.Items.Clear();
         MainWindow.comboBoxMappingFilterAircraft.Items.Clear();
         MainWindow.comboBoxProfileFilterAircraft.Items.Add(PROFILE_FILTER_ANY_AIRCAFT);
         MainWindow.comboBoxProfileFilterDevice.Items.Add(PROFILE_FILTER_ANY_DEVICE);
         MainWindow.comboBoxMappingFilterAircraft.Items.Add(PROFILE_FILTER_ANY_AIRCAFT);
         for (int id = 0; id < VLED.Engine.CurrentSettings.Devices.Count; id++)
         {
            VirpilDevice device = VLED.Engine.CurrentSettings.Devices.ElementAt(id);
            MainWindow.comboBoxProfileFilterDevice.Items.Add(id + ": " + device.Name);
         }
         IReadOnlyCollection<String> aircrafts = profile.GetAircraftList();
         foreach (String aircraft in aircrafts)
         {
            MainWindow.comboBoxProfileFilterAircraft.Items.Add(aircraft);
            MainWindow.comboBoxMappingFilterAircraft.Items.Add(aircraft);
         }
      }

      internal void EditMapping(int index)
      {
         System.Windows.Forms.ListViewItem item = MainWindow.listViewMapping.Items[index];
         int id = Tools.ToInt(item.Text);
         String aircraft = item.SubItems[1].Text;

         Profile.MappingEntry entry = VLED.Engine.CurrentProfile.GetMapingEntry(aircraft, id);
         if(entry!=null)
         {
            EditMappingEntryDialog dialog = new EditMappingEntryDialog();
            dialog.Profile = VLED.Engine.CurrentProfile;
            dialog.MappingEntry = entry;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               // Remove 
               VLED.Engine.CurrentProfile.RemoveMapping(entry);
               // Change
               entry.Aircraft = dialog.GetAircraft();
               entry.Id = dialog.GetId();
               entry.Name = dialog.GetName();
               // Reinsert for correcct internal Mapping
               VLED.Engine.CurrentProfile.AddMapping(entry);

               MainWindow.listViewMapping.BeginInvoke(
                  new Action(() =>
                  {
                     System.Windows.Forms.ListViewItem changeditem = MainWindow.listViewMapping.Items[index];
                     changeditem.Text = entry.Id.ToString();
                     changeditem.SubItems[1].Text = entry.Aircraft;
                     changeditem.SubItems[2].Text = entry.Name;
                     MainWindow.listViewMapping.Sort();
                  })
               );
            }
         }
      }

      public void AddNewProfileEvent()
      {
         EditProfileEventDialog dialog = new EditProfileEventDialog() { Profile = VLED.Engine.CurrentProfile };
         if (dialog.ShowDialog() == DialogResult.OK)
         {
            int eventId = dialog.GetEventId();
            String aircraft = dialog.GetAircraft();
            String condition1 = dialog.GetPrimaryCondition();
            String condition2 = dialog.GetSecondaryCondition();
            double value1 = dialog.GetPrimaryValue();
            double value2 = dialog.GetSecondaryValue();
            int deviceId = dialog.GetDeviceId();
            int led = dialog.GetLedNumber();
            LedColor color1 = dialog.GetColorOn();
            LedColor color2 = dialog.GetColorFlashing();
            String description = dialog.GetDescription();

            //Profile.ProfileEvent newEvent = VLED.Engine.CurrentProfile.AddProfileEvent(aircraft, eventId, condition1, value1, condition2, value2, deviceId, led, color1, color2, description);

            Profile.ProfileEvent newEvent = new Profile.ProfileEvent(aircraft, eventId, condition1, value1, condition2, value2, deviceId, led, color1, color2, description);
            newEvent.Enabled = dialog.GetEnabled();

            int index = VLED.Engine.CurrentProfile.ProfileEvents.Count;
            int selected = MainWindow.listViewProfileEvents.Items.Count;
            if (MainWindow.listViewProfileEvents.SelectedItems.Count > 0 && !MainWindow.radioButtonNewElementsAppend.Checked)
            {
               System.Windows.Forms.ListViewItem item = MainWindow.listViewProfileEvents.SelectedItems[0];
               index = (int)item.Tag;
               selected = MainWindow.listViewProfileEvents.SelectedIndices[0];

               if (MainWindow.radioButtonNewElementsInsertAfter.Checked)
               {
                  index++;
                  selected++;
               }
            }

            VLED.Engine.CurrentProfile.InsertProfileEvent(index,newEvent);

            MainWindow.listViewProfileEvents.BeginInvoke(
               new Action(() =>
               {
                  System.Windows.Forms.ListViewItem item = MainWindow.listViewProfileEvents.Items.Insert(selected,newEvent.Id.ToString());
                  item.Tag = (int)index;
                  item.SubItems.Add(newEvent.Aircraft);
                  item.SubItems.Add(VLED.Engine.CurrentProfile.MapPropertyName(newEvent.Aircraft, newEvent.Id));
                  item.SubItems.Add(newEvent.GetConditionsAsString());
                  item.SubItems.Add(newEvent.DeviceId.ToString());
                  item.SubItems.Add(newEvent.LedNumber.ToString());
                  item.SubItems.Add(newEvent.ColorOn.AsString());
                  item.SubItems.Add(newEvent.ColorFlashing.AsString());
                  item.SubItems.Add(Tools.EnabledToYesNo(newEvent.Enabled));
                  item.SubItems.Add(newEvent.Description);
                  //
                  for (int i = selected + 1; i < MainWindow.listViewProfileEvents.Items.Count; i++)
                  {
                     item = MainWindow.listViewProfileEvents.Items[i];
                     item.Tag = (int)item.Tag + 1;
                  }
               })
            );
            UpdateProfileFilter(VLED.Engine.CurrentProfile);
         }
      }

      public void AddQuickProfileEvent()
      {
         QuickAddDialog dialog = new QuickAddDialog() { Profile = VLED.Engine.CurrentProfile };
         if (dialog.ShowDialog() == DialogResult.OK)
         {
            // String aircraft, int id, String primaryCondition, double primaryValue, String secondaryCondition, double secondaryValue,  int deviceId, int ledNumber, LedColor colorOn, LedColor colorFlashing, String description
            String aircraft = dialog.GetAircraft();
            int eventId = dialog.GetEventId();
            int deviceId = dialog.GetDeviceId();
            int ledNumber = dialog.GetLedNumber();
            LedColor colorOn = dialog.GetColorOn();
            LedColor colorOff = dialog.GetColorOff();
            String description = dialog.GetDescription();
            Profile.ProfileEvent off = new Profile.ProfileEvent(aircraft, eventId, "=", 0.0, "-", 0.0, deviceId, ledNumber, colorOff, colorOff, description + " OFF");
            Profile.ProfileEvent on = new Profile.ProfileEvent(aircraft,eventId,"=",1.0,"-",0.0,deviceId, ledNumber, colorOn,colorOn,description+" ON");

            int index = VLED.Engine.CurrentProfile.ProfileEvents.Count;
            int selected = MainWindow.listViewProfileEvents.Items.Count;
            if (MainWindow.listViewProfileEvents.SelectedItems.Count>0 && !MainWindow.radioButtonNewElementsAppend.Checked)
            {
               System.Windows.Forms.ListViewItem item = MainWindow.listViewProfileEvents.SelectedItems[0];
               index = (int)item.Tag;
               selected = MainWindow.listViewProfileEvents.SelectedIndices[0];

               if (MainWindow.radioButtonNewElementsInsertAfter.Checked)
               {
                  index++;
                  selected++;
               }
            }

            VLED.Engine.CurrentProfile.InsertProfileEvent(index, off);
            VLED.Engine.CurrentProfile.InsertProfileEvent(index + 1, on);

            MainWindow.listViewProfileEvents.BeginInvoke(
               new Action(() =>
               {
                  System.Windows.Forms.ListViewItem offItem = MainWindow.listViewProfileEvents.Items.Insert(selected, off.Id.ToString());
                  offItem.Tag = index;
                  offItem.SubItems.Add(off.Aircraft);
                  offItem.SubItems.Add(VLED.Engine.CurrentProfile.MapPropertyName(off.Aircraft, off.Id));
                  offItem.SubItems.Add(off.GetConditionsAsString());
                  offItem.SubItems.Add(off.DeviceId.ToString());
                  offItem.SubItems.Add(off.LedNumber.ToString());
                  offItem.SubItems.Add(off.ColorOn.AsString());
                  offItem.SubItems.Add(off.ColorFlashing.AsString());
                  offItem.SubItems.Add(Tools.EnabledToYesNo(off.Enabled));
                  offItem.SubItems.Add(off.Description);

                  System.Windows.Forms.ListViewItem onItem = MainWindow.listViewProfileEvents.Items.Insert(selected+1, off.Id.ToString());
                  onItem.Tag = index+1;
                  onItem.SubItems.Add(on.Aircraft);
                  onItem.SubItems.Add(VLED.Engine.CurrentProfile.MapPropertyName(on.Aircraft, on.Id));
                  onItem.SubItems.Add(on.GetConditionsAsString());
                  onItem.SubItems.Add(on.DeviceId.ToString());
                  onItem.SubItems.Add(on.LedNumber.ToString());
                  onItem.SubItems.Add(on.ColorOn.AsString());
                  onItem.SubItems.Add(on.ColorFlashing.AsString());
                  onItem.SubItems.Add(Tools.EnabledToYesNo(on.Enabled));
                  onItem.SubItems.Add(on.Description);

                  for(int i= selected+2; i< MainWindow.listViewProfileEvents.Items.Count; i++ )
                  {
                     System.Windows.Forms.ListViewItem item = MainWindow.listViewProfileEvents.Items[i];
                     item.Tag = (int)item.Tag + 2;
                  }
               })
            );

         }
      }


      internal bool EnableProfileEvent(bool enable)
      {
         if (MainWindow.listViewProfileEvents.SelectedIndices.Count == 0) return true;
         System.Windows.Forms.ListViewItem item = MainWindow.listViewProfileEvents.SelectedItems[0];

         int index = (int)item.Tag;

         if (index < VLED.Engine.CurrentProfile.ProfileEvents.Count)
         {
            Profile.ProfileEvent entry = VLED.Engine.CurrentProfile.ProfileEvents[index];
            entry.Enabled = enable;
            item.SubItems[8].Text = Tools.EnabledToYesNo(enable);
            return enable;
         }
         return true;
      }

      internal void EditProfileEvent()
      {
         if (MainWindow.listViewProfileEvents.SelectedIndices.Count == 0) return;
         System.Windows.Forms.ListViewItem item = MainWindow.listViewProfileEvents.SelectedItems[0];

         int index = (int)item.Tag;
         int selected = MainWindow.listViewProfileEvents.SelectedIndices[0];
         LogDebug("profile edit: index="+index+", selected="+selected);

         if (index < VLED.Engine.CurrentProfile.ProfileEvents.Count)
         {
            EditProfileEventDialog dialog = new EditProfileEventDialog() { Profile = VLED.Engine.CurrentProfile };
            Profile.ProfileEvent edit = VLED.Engine.CurrentProfile.ProfileEvents[index];
            dialog.Event = edit;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               edit.Id = dialog.GetEventId();
               edit.Aircraft = dialog.GetAircraft();
               edit.PrimaryCondition = dialog.GetPrimaryCondition();
               edit.SecondaryCondition = dialog.GetSecondaryCondition();
               edit.PrimaryValue = dialog.GetPrimaryValue();
               edit.SecondaryValue = dialog.GetSecondaryValue();
               edit.DeviceId = dialog.GetDeviceId();
               edit.LedNumber = dialog.GetLedNumber();
               edit.ColorOn = dialog.GetColorOn();
               edit.ColorFlashing = dialog.GetColorFlashing();
               edit.Description = dialog.GetDescription();

               MainWindow.listViewProfileEvents.BeginInvoke(
                  new Action(() =>
                  {
                     item.Text = edit.Id.ToString();
                     item.SubItems[1].Text = edit.Aircraft;
                     item.SubItems[2].Text = VLED.Engine.CurrentProfile.MapPropertyName(edit.Aircraft, edit.Id);
                     item.SubItems[3].Text = edit.GetConditionsAsString();
                     item.SubItems[4].Text = edit.DeviceId.ToString();
                     item.SubItems[5].Text = edit.LedNumber.ToString();
                     item.SubItems[6].Text = edit.ColorOn.AsString();
                     item.SubItems[7].Text = edit.ColorFlashing.AsString();
                     item.SubItems[8].Text = Tools.EnabledToYesNo(edit.Enabled);
                     item.SubItems[9].Text = edit.Description;
                  })
               );
            }

         }
      }


      private void SetComboboxSelection(ComboBox box, int index)
      {
         box.Invoke(
         new Action(() =>
         {
            box.SelectedItem = box.Items[index];
         }));
      }

      internal void SetSettingsLogLevel(LEVEL level)
      {
         bool modified = (level != DisplayedSettings.LogLevel);

         LogInfo("Set Log Level " + level+ " in Settings");

         SettingsUpdating = true;
         switch (level)
         {
            case LEVEL.OFF:
               DisplayedSettings.LogLevel = LEVEL.OFF;
               SetComboboxSelection(MainWindow.comboBoxLogLevel, 0);
               break;
            case LEVEL.ERROR:
               DisplayedSettings.LogLevel = LEVEL.ERROR;
               SetComboboxSelection(MainWindow.comboBoxLogLevel, 1);
               break;
            case LEVEL.WARNING:
               DisplayedSettings.LogLevel = LEVEL.WARNING;
               SetComboboxSelection(MainWindow.comboBoxLogLevel, 2);
               break;
            case LEVEL.INFO:
               DisplayedSettings.LogLevel = LEVEL.INFO;
               SetComboboxSelection(MainWindow.comboBoxLogLevel, 3);
               break;
            case LEVEL.DEBUG:
               DisplayedSettings.LogLevel = LEVEL.DEBUG;
               SetComboboxSelection(MainWindow.comboBoxLogLevel, 4);
               break;
            case LEVEL.TRACE:
               DisplayedSettings.LogLevel = LEVEL.TRACE;
               SetComboboxSelection(MainWindow.comboBoxLogLevel, 5);
               break;
         }
         SettingsUpdating = false;
         SetSettingsModified(modified);
      }

      private void SetSettingsModified(bool modified)
      {
         SetControlEnabled(MainWindow.buttonSettingsSave, modified);
         SetControlEnabled(MainWindow.buttonSettingsCancel, modified);
      }


      public String ChooseDefaultProfile()
      {
         using (OpenFileDialog chooser = new OpenFileDialog())
         {
            chooser.InitialDirectory =Tools.GetApplicationFolder();
            chooser.Multiselect = false;
            chooser.Filter = "profile files (*.profile)|*.profile";
            chooser.FilterIndex = 1;
            chooser.RestoreDirectory = true;
            if (chooser.ShowDialog() == DialogResult.OK)
            {
               DisplayedSettings.DefaultProfile = chooser.FileName;
               SetSettingsModified(true);
               return chooser.FileName;
            }
            return null;
         }
      }

      public void SetAircraftName(String name)
      {
         LogDebug("Set aircraft name to '" + name + "'");

         if (MainWindow.IsHandleCreated)
         {
            if (name == null || name == "")
            {
               name = NO_AIRCRAFT;
            }
            try
            {
               MainWindow.textBoxAircraft.BeginInvoke(
                  new Action(() => MainWindow.textBoxAircraft.Text = name)
                  );
            }
            catch (Exception e)
            {
               LogException(e);
            }
         }

      }

   }
}
