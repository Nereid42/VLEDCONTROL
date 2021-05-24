using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace VLEDCONTROL
{
   public class Settings : Loggable
   {
      private const string FILENAME = "vled.ini";

      public List<VirpilDevice> Devices { get; set; } = new List<VirpilDevice>();
      public String VirpilLedControl { get; set; } = "";
      public String DefaultProfile { get; set; } = "Default.profile";
      public double UpdateInterval { get; set; } = 0.1;
      public double DataInterval { get; set; } = 0.3;
      public int FlashingCycles { get; set; } = 5;
      public Loggable.LEVEL LogLevel { get; set; } = Loggable.LEVEL.DEBUG;

      public static bool FileExists()
      {
         return System.IO.File.Exists(FILENAME);
      }

      public void Load()
      {
         String json = File.ReadAllText(FILENAME);
         Settings loadedSettings = JsonSerializer.Deserialize<Settings>(json);
         CopySettings(loadedSettings);
      }

      public void CopySettings(Settings settings)
      {
         this.Devices.Clear();
         foreach (VirpilDevice device in settings.Devices)
         {
            Devices.Add(device);
         }
         this.VirpilLedControl = settings.VirpilLedControl;
         this.DefaultProfile = settings.DefaultProfile;
         this.UpdateInterval = settings.UpdateInterval;
         this.DataInterval = settings.DataInterval;
         this.LogLevel = settings.LogLevel;
      }

      public void Save()
      {
         LogInfo("saving settings");
         String json = JsonSerializer.Serialize(this);

         using (FileStream stream = File.Open(FILENAME, FileMode.Create))
         {
            byte[] bytes = Encoding.ASCII.GetBytes(json);
            stream.Write(bytes,0,bytes.Length);
         }
      }

      internal void AddDevice(VirpilDevice device)
      {
         Devices.Add(device);
      }

      public VirpilDevice GetDevice(int id)
      {
         if(Devices.Count<=id) return null;
         return Devices.ElementAt(id);
      }

      public void RemoveDevice(int id)
      {
         if (Devices.Count < id) return;
         Devices.RemoveAt(id);
      }

      public void InsertDevice(int id, VirpilDevice device)
      {
         Devices.Insert(id, device);
      }


      public int GetDeviceId(VirpilDevice device)
      {
         return Devices.IndexOf(device);
      }

      public async void SaveAsync()
      {
         LogInfo("saving settings (async)");
         String json = JsonSerializer.Serialize(this);

         using (FileStream stream = File.Open(FILENAME, FileMode.Create))
         {
            byte[] bytes = Encoding.ASCII.GetBytes(json);
            await stream.WriteAsync(bytes, 0, bytes.Length);
         }
      }


      internal int GetUpdateIntervalInMillis()
      {
         const int MILLIS_PER_SECOND = 1000;
         return (int)(UpdateInterval * MILLIS_PER_SECOND);
      }
   }
}
