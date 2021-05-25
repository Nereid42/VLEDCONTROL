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

      private const Loggable.LEVEL DEFAULT_LOGLEVEL = Loggable.LEVEL.INFO;

      public List<VirpilDevice> Devices { get; set; } = new List<VirpilDevice>();
      public String VirpilLedControl { get; set; } = "";
      public String DefaultProfile { get; set; } = "Default.profile";
      public double UpdateInterval { get; set; } = 0.5;
      public double DataInterval { get; set; } = 0.3;
      public int FlashingCycles { get; set; } = 2;
      public Loggable.LEVEL LogLevel { get; set; } = DEFAULT_LOGLEVEL;
      public bool StatisticsEnabled { get; set; } = true;

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
