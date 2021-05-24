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
      private readonly MainWindowForm MainWindow;
      private Settings DisplayedSettings = new Settings();

      private readonly ArrayList data = new ArrayList();

      public bool SettingsUpdating { get; private set; } = false;

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


      public void SetData(int id, String name, double value, DateTime lastChange)
      {

         if (MainWindow.IsHandleCreated)
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

      internal void StartStopEngine()
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

      internal void SetEngineStarted(bool started)
      {
         if(started)
         {
            MainWindow.buttonMainStart.BackColor = System.Drawing.Color.GreenYellow;
            MainWindow.buttonMainStart.Text = "STOP";
            MainWindow.progressBarEngineStatus.MarqueeAnimationSpeed = 40;
         }
         else
         {
            MainWindow.buttonMainStart.BackColor = System.Drawing.Color.Coral;
            MainWindow.buttonMainStart.Text = "START";
            MainWindow.progressBarEngineStatus.MarqueeAnimationSpeed = 0;
            MainWindow.progressBarEngineStatus.Value = 0;
         }
      }

      internal void LoadProfile()
      {
         using (OpenFileDialog chooser = new OpenFileDialog())
         {

            chooser.InitialDirectory = chooser.InitialDirectory = Tools.GetApplicationFolder();
            chooser.Multiselect = false;
            chooser.Filter = "Profile files (*.profile)|*.profile";
            chooser.FilterIndex = 1;
            chooser.RestoreDirectory = true;
            if (chooser.ShowDialog() == DialogResult.OK)
            {
               VLED.Engine.CurrentProfile = Profile.Load(chooser.FileName);
               SetProfile(VLED.Engine.CurrentProfile);
            }
         }
      }

      internal void SaveProfile()
      {
         using (SaveFileDialog chooser = new SaveFileDialog())
         {

            chooser.InitialDirectory = chooser.InitialDirectory = Tools.GetApplicationFolder();
            chooser.Filter = "Profile files (*.profile)|*.profile";
            chooser.FilterIndex = 1;
            chooser.RestoreDirectory = true;
            if (chooser.ShowDialog() == DialogResult.OK)
            {
               String filename = chooser.FileName;
               String name = filename;
               int p = filename.LastIndexOf('.');
               if(p>=0)
               {
                  name = name.Remove(p);
               }
               VLED.Engine.CurrentProfile.Name = name;
               VLED.Engine.CurrentProfile.SaveAs(filename);
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

         SetTextBoxText(MainWindow.textBoxSettingsVirpilLedControl, settings.VirpilLedControl,false);
         SetTextBoxText(MainWindow.textBoxSettingsDefaultProfile, settings.DefaultProfile, false);
         // Intervals
         SetTextBoxText(MainWindow.textBoxSettingsDataInterval, settings.DataInterval.ToString(), false);
         SetTextBoxText(MainWindow.textBoxSettingsFlashingCycles, settings.FlashingCycles.ToString(), false);
         SetTextBoxText(MainWindow.textBoxSettingsUpdateInterval, settings.UpdateInterval.ToString(), false);
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
         }
         catch { /* nothing */  }
         SetTextBoxText(MainWindow.textBoxSettingsDataInterval, interval.ToString(), false);
         SettingsUpdating = false;
      }

      public void SetProfile(Profile profile)
      {
         MainWindow.listViewProfileEvents.BeginInvoke(
            new Action(() =>
            {
               MainWindow.listViewProfileEvents.Items.Clear();
               foreach(Profile.ProfileEvent entry in profile.ProfileEvents)
               {
                  System.Windows.Forms.ListViewItem item = MainWindow.listViewProfileEvents.Items.Add(entry.Id.ToString());
                  item.BackColor = System.Drawing.Color.Empty;
                  item.SubItems.Add(entry.Aircraft);
                  item.SubItems.Add(profile.MapPropertyName(entry.Aircraft,entry.Id));
                  item.SubItems.Add(entry.GetConditionsAsString());
                  item.SubItems.Add(entry.DeviceId.ToString());
                  item.SubItems.Add(entry.ColorOn.AsString());
                  item.SubItems.Add(entry.ColorFlashing.AsString());
                  item.SubItems.Add(entry.Description);
               }

               MainWindow.listViewMapping.Items.Clear();
               foreach (Profile.MappingEntry entry in profile.MappingEntries)
               {
                  System.Windows.Forms.ListViewItem item = MainWindow.listViewMapping.Items.Add(entry.Id.ToString());
                  item.SubItems.Add(entry.Aircraft);
                  item.SubItems.Add(entry.Name);
               }
            })
         );
         SetTextBoxText(MainWindow.textBoxProfileName, profile.Name);
         SetTextBoxText(MainWindow.textBoxMappingProfileName, profile.Name);
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
         SetSettingsModified(false);
         VLED.Engine.CurrentSettings.SaveAsync();
         SetSettingsLogLevel(VLED.Engine.CurrentSettings.LogLevel);
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
         EditDeviceDialog dialog = new EditDeviceDialog();
         dialog.Id = MainWindow.listViewSettingsDevices.Items.Count;
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
            device.USB_VID = dialog.GetUsbVid();
            device.USB_PID = dialog.GetUsbPid();
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
         VLED.Engine.CurrentProfile.MappingEntries.RemoveAt(index);
         MainWindow.listViewMapping.BeginInvoke(
         new Action(() =>
         {
            MainWindow.listViewMapping.Items.RemoveAt(index);
         })
         );
      }

      internal void AddNewMapping()
      {
         EditMappingEntryDialog dialog = new EditMappingEntryDialog();
         dialog.Profile = VLED.Engine.CurrentProfile;

         if (dialog.ShowDialog() == DialogResult.OK)
         {
            String aircraft = dialog.GetAircraft();
            int id = dialog.GetId();
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
      }

      internal void EditMapping(int index)
      {
         Profile.MappingEntry entry = VLED.Engine.CurrentProfile.MappingEntries.ElementAt(index);

         EditMappingEntryDialog dialog = new EditMappingEntryDialog();
         dialog.Profile = VLED.Engine.CurrentProfile;
         dialog.MappingEntry = entry;
         if (dialog.ShowDialog() == DialogResult.OK)
         {
            entry.Aircraft = dialog.GetAircraft();
            entry.Id = dialog.GetId();
            entry.Name = dialog.GetName();
            MainWindow.listViewMapping.BeginInvoke(
            new Action(() =>
            {
               System.Windows.Forms.ListViewItem item = MainWindow.listViewMapping.Items[index];
               item.Text = entry.Id.ToString();
               item.SubItems[1].Text = entry.Aircraft;
               item.SubItems[2].Text = entry.Name;
               })
            );
         }
      }

      public void AddNewProfileEvent()
      {
         EditProfileEventDialog dialog = new EditProfileEventDialog();
         dialog.Profile = VLED.Engine.CurrentProfile;
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
            Color color1 = dialog.GetColorOn();
            Color color2 = dialog.GetColorFlashing();

            Profile.ProfileEvent newEvent = VLED.Engine.CurrentProfile.AddProfileEvent(aircraft, eventId, condition1, value1, condition2, value2, deviceId, led, color1, color2);

            MainWindow.listViewProfileEvents.BeginInvoke(
               new Action(() =>
               {
                  System.Windows.Forms.ListViewItem item = MainWindow.listViewProfileEvents.Items.Add(newEvent.Id.ToString());
                  item.SubItems.Add(newEvent.Aircraft);
                  item.SubItems.Add(VLED.Engine.CurrentProfile.MapPropertyName(newEvent.Aircraft, newEvent.Id));
                  item.SubItems.Add(newEvent.GetConditionsAsString());
                  item.SubItems.Add(newEvent.DeviceId.ToString());
                  item.SubItems.Add(newEvent.ColorOn.AsString());
                  item.SubItems.Add(newEvent.ColorFlashing.AsString());
                  item.SubItems.Add(newEvent.Description);
               })
            );
         }
      }

      internal void EditProfileEvent(int index)
      {
         if (index < VLED.Engine.CurrentProfile.ProfileEvents.Count)
         {
            EditProfileEventDialog dialog = new EditProfileEventDialog();
            dialog.Profile = VLED.Engine.CurrentProfile;
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

               MainWindow.listViewProfileEvents.BeginInvoke(
                  new Action(() =>
                  {
                     System.Windows.Forms.ListViewItem item = MainWindow.listViewProfileEvents.Items[index];
                     item.Text = edit.Id.ToString();
                     item.SubItems[1].Text = edit.Aircraft;
                     item.SubItems[2].Text = VLED.Engine.CurrentProfile.MapPropertyName(edit.Aircraft, edit.Id);
                     item.SubItems[3].Text = edit.GetConditionsAsString();
                     item.SubItems[4].Text = edit.DeviceId.ToString();
                     item.SubItems[5].Text = edit.ColorOn.AsString();
                     item.SubItems[6].Text = edit.ColorFlashing.AsString();
                     item.SubItems[7].Text = edit.Description;
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

      public void SetSettingsModified(bool modified)
      {
         SetControlEnabled(MainWindow.buttonSettingsSave, modified);
         SetControlEnabled(MainWindow.buttonSettingsCancel, modified);
      }


      public String ChooseVirpilLedControl()
      {
         using (OpenFileDialog chooser = new OpenFileDialog())
         {
            String path = VLED.Engine.CurrentSettings.VirpilLedControl;
            if (path != null && path.Length > 0 && !path.EndsWith("/"))
            {
               int p = path.LastIndexOf('/');
               if (p >= 0)
               {
                  path = path.Remove(p);
               }
            }
            else
            {
               path = "C:/";
            }

            chooser.InitialDirectory = path.Replace('/', '\\');
            chooser.Multiselect = false;
            chooser.Filter = "exe files (*.exe)|*.exe";
            chooser.FilterIndex = 1;
            chooser.RestoreDirectory = true;
            if (chooser.ShowDialog() == DialogResult.OK)
            {
               DisplayedSettings.VirpilLedControl = chooser.FileName;
               SetSettingsModified(true);
               return chooser.FileName;
            }
            return null;
         }
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
               name = "- NO AIRCRAFT -";
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
