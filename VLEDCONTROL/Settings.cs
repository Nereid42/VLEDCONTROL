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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace VLEDCONTROL
{
   public class Settings : Loggable
   {
      private const string FILENAME = "vled.ini";

      private const Loggable.LEVEL DEFAULT_LOGLEVEL = Loggable.LEVEL.INFO;

      private volatile bool _AutostartEnabled = true;
      private volatile bool _StatisticsEnabled = true;
      private volatile bool _LiveDataEnabled = true;
      private volatile List<VirpilDevice> _Devices = new List<VirpilDevice>();
      private volatile String _VirpilLedControl = "";
      private volatile String _DefaultProfile = "Default.profile";
      private volatile int _FlashingCycles = 2;
      private volatile Loggable.LEVEL _LogLevel = DEFAULT_LOGLEVEL;
      public volatile float _UpdateInterval = 0.2f;
      public volatile float _DataInterval = 0.3f;

      public List<VirpilDevice> Devices { get { return _Devices; } set { _Devices = value; } }
      public String VirpilLedControl { get { return _VirpilLedControl; } set { _VirpilLedControl = value; } }
      public String DefaultProfile { get { return _DefaultProfile; } set { _DefaultProfile = value; } }
      public double UpdateInterval { get { return _UpdateInterval; } set { _UpdateInterval = (float)value; } }
      public double DataInterval { get { return _DataInterval; } set { _DataInterval = (float)value; } }
      public int FlashingCycles { get { return _FlashingCycles; } set { _FlashingCycles = value; } }
      public Loggable.LEVEL LogLevel { get { return _LogLevel; } set { _LogLevel = value; } }
      public bool StatisticsEnabled { get { return _StatisticsEnabled; } set { _StatisticsEnabled = value; } } 
      public bool LiveDataEnabled { get { return _LiveDataEnabled; } set { _LiveDataEnabled = value; } }
      public bool AutostartEnabled { get { return _AutostartEnabled; } set { _AutostartEnabled = value; } }

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
         lock(this)
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
            this.StatisticsEnabled = settings.StatisticsEnabled;
            this.FlashingCycles = settings.FlashingCycles;
            this.LiveDataEnabled = settings.LiveDataEnabled;
            this.AutostartEnabled = settings.AutostartEnabled;
         }
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
         LogInfo("Settings saved");
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
