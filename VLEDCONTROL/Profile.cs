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
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace VLEDCONTROL
{
   public class Profile : Loggable
   {
      public String Name { get; set; } = "Default";

      public List<ProfileEvent> ProfileEvents { get; set; } = new List<ProfileEvent>();
      public List<MappingEntry> MappingEntries { get; set; } = new List<MappingEntry>();

      private Dictionary<Tuple<String, int>, MappingEntry> MapNameEntries = new Dictionary<Tuple<string, int>, MappingEntry>();
      private Dictionary<Tuple<String, String>, MappingEntry> MapNameEventId = new Dictionary<Tuple<String, String>, MappingEntry>();
      private Dictionary<String,List<String>> MapAircraftEvents = new Dictionary<String, List<String>>();

      private static readonly IReadOnlyCollection<String> EMPTY_COLLECTION = (new List<string>()).AsReadOnly();

      private String GetFileName()
      {
         if (Name.EndsWith(".profie")) return Name;
         return Name + ".profile";
      }

      public Profile()
      {
      }


      public static Profile Load(String filename)
      {
         LogDebug("loading profile "+filename);
         String json = File.ReadAllText(filename);
         Profile profile = JsonSerializer.Deserialize<Profile>(json);

         foreach(MappingEntry entry in profile.MappingEntries)
         {
            LogDebug("adding entry "+entry);
            Tuple<String, int> mapid = new Tuple<String, int>(entry.Aircraft, entry.Id);
            profile.MapNameEntries.Add(mapid, entry);
            Tuple<String, String> nameid = new Tuple<String, String>(entry.Aircraft, entry.Name);
            profile.MapNameEventId.Add(nameid,entry);
            // Setup Aircraft-Events Map
            List<String> eventsForAircraft;
            if (! profile.MapAircraftEvents.TryGetValue(entry.Aircraft, out eventsForAircraft))
            {
               eventsForAircraft = new List<String>();
               profile.MapAircraftEvents.Add(entry.Aircraft, eventsForAircraft);
            }
            eventsForAircraft.Add(entry.Name);
         }

         return profile;
      }

      public void Save()
      {
         LogInfo("saving profile "+Name);
         SaveAs(GetFileName());
      }

      public void SaveAs(String filename)
      {
         LogInfo("saving profile " + Name);
         String json = JsonSerializer.Serialize(this);
         using (FileStream stream = File.Open(filename, FileMode.Create))
         {
            byte[] bytes = Encoding.ASCII.GetBytes(json);
            stream.Write(bytes, 0, bytes.Length);
         }
      }

      public async void SaveAsync()
      {
         LogInfo("saving settings (async) "+Name);
         String json = JsonSerializer.Serialize(this);

         String filename = GetFileName();
         using (FileStream stream = File.Open(filename, FileMode.Create))
         {
            byte[] bytes = Encoding.ASCII.GetBytes(json);
            await stream.WriteAsync(bytes, 0, bytes.Length);
         }
      }

      internal void RemoveMapping(MappingEntry entry)
      {
         MappingEntries.Remove(entry);
         Tuple<String, int> mapid = new Tuple<String, int>(entry.Aircraft, entry.Id);
         MapNameEntries.Remove(mapid);
         Tuple<String, String> nameid = new Tuple<String, String>(entry.Aircraft, entry.Name);
         MapNameEventId.Remove(nameid);
         List<String> eventsForAircraft;
         if (MapAircraftEvents.TryGetValue(entry.Aircraft, out eventsForAircraft))
         {
            eventsForAircraft.Remove(entry.Name);
            eventsForAircraft.Sort();
         }
      }

      public void RemoveMapping(String aircraft, int id)
      {
         MappingEntry entry;

         Tuple<String, int> mapid = new Tuple<String, int>(aircraft, id);
         if (MapNameEntries.TryGetValue(mapid, out entry))
         {
            RemoveMapping(entry);
         }
      }

      internal void AddMapping(MappingEntry entry)
      {
         try
         {
            MappingEntries.Add(entry);
            Tuple<String, int> mapid = new Tuple<String, int>(entry.Aircraft, entry.Id);
            MapNameEntries.Add(mapid, entry);
            Tuple<String, String> nameid = new Tuple<String, String>(entry.Aircraft, entry.Name);
            MapNameEventId.Add(nameid, entry);
            // add mapping for aircraft events
            List<String> eventsForAircraft;
            if (!MapAircraftEvents.TryGetValue(entry.Aircraft, out eventsForAircraft))
            {
               eventsForAircraft = new List<String>();
               MapAircraftEvents.Add(entry.Aircraft, eventsForAircraft);
            }
            eventsForAircraft.Add(entry.Name);
            eventsForAircraft.Sort();
         } 
         catch(Exception e)
         {
            LogError("failed to add mapping entry "+entry);
            LogException(e);
         }
      }

      public void AddMapping(String aircraft, int id, String name)
      {
         MappingEntry entry = new MappingEntry(aircraft, id, name);
         AddMapping(entry);
      }

      public bool ContainsMapping(String aircraft, int id)
      {
         Tuple<String, int> mapid = new Tuple<String, int>(aircraft, id);
         return MapNameEntries.ContainsKey(mapid);
      }

      public bool ContainsMapping(String aircraft, String name)
      {
         Tuple<String, String> nameid = new Tuple<String, String>(aircraft, name);
         return MapNameEventId.ContainsKey(nameid);
      }

      public IReadOnlyCollection<String> GetEventNamesForAircraft(String aircraft)
      {
         List<String> result;
         if (MapAircraftEvents.TryGetValue(aircraft, out result))
         {
            return result.AsReadOnly();
         }
         return EMPTY_COLLECTION;
      }

      public String MapPropertyName(String aircraft, int id)
      {
         Tuple<String, int> mapid = new Tuple<String, int>(aircraft, id);

         MappingEntry entry;

         if (MapNameEntries.TryGetValue(mapid, out entry))
         {
            return entry.Name;
         }
         return "";
      }

      public int MapPropertyId(String aircraft, String name)
      {
         Tuple<String, String> nameid = new Tuple<String, String>(aircraft, name);
         MappingEntry entry;

         if (MapNameEventId.TryGetValue(nameid, out entry))
         {
            return entry.Id;
         }
         return 0;
      }

      internal MappingEntry GetMapingEntry(string aircraft, int id)
      {
         Tuple<String, int> mapid = new Tuple<String, int>(aircraft, id);

         MappingEntry entry;

         if (MapNameEntries.TryGetValue(mapid, out entry))
         {
            return entry;
         }
         return null;
      }

      internal void ImportMapping(Profile profile)
      {
         foreach (MappingEntry entry in profile.MappingEntries)
         {
            if(ContainsMapping(entry.Aircraft,entry.Id))
            {
               RemoveMapping(entry.Aircraft, entry.Id);
            }
            AddMapping(entry);
         }
      }

      public ProfileEvent AddProfileEvent(String aircraft, int id, String condition1, double value1, String condition2, double value2, int deviceId, int ledNumber, LedColor colorOn, LedColor colorFlashing, String description)
      {
         ProfileEvent entry = new ProfileEvent(aircraft, id, condition1, value1, condition2, value2, deviceId, ledNumber, colorOn, colorFlashing, description);
         AddProfileEntry(entry);
         return entry;
      }

      public void AddProfileEntry(ProfileEvent entry)
      {
         ProfileEvents.Add(entry);
      }

      public void InsertProfileEntry(int index, ProfileEvent entry)
      {
         ProfileEvents.Insert(index,entry);
      }

      public void RemoveProfileEntryAt(int index)
      {
         ProfileEvents.RemoveAt(index);
      }


      internal void ClearProfileEvents()
      {
         ProfileEvents.Clear();
      }

      public class MappingEntry : IComparable
      {
         public int Id { get; set; }
         public String Aircraft { get; set; }
         public String Name { get; set; }

         public MappingEntry(String aircraft, int id, String name)
         {
            this.Id = id;
            this.Aircraft = aircraft;
            this.Name = name;
         }

         public override bool Equals(object obj)
         {
            if (obj is null) return false;
            if (obj.GetType() != typeof(MappingEntry)) return false;
            MappingEntry cmp = (MappingEntry)obj;
            return this.Id == cmp.Id && this.Aircraft.Equals(cmp.Aircraft) && this.Name.Equals(cmp.Name);
         }

         public override int GetHashCode()
         {
            return this.Id * this.Aircraft.GetHashCode();
         }

         public override string ToString()
         {
            return Id + ":" + Aircraft + ":" + Name;
         }

         public int CompareTo(object obj)
         {
            if (!(obj is MappingEntry)) return 1;
            return this.CompareTo((MappingEntry)obj);
         }
      }

      public IReadOnlyCollection<String> GetAircraftList()
      {
         HashSet<String> aircrafts = new HashSet<String>();

         foreach(ProfileEvent e in ProfileEvents)
         {
            aircrafts.Add(e.Aircraft);
         }
         foreach(MappingEntry e in MappingEntries)
         {
            aircrafts.Add(e.Aircraft);
         }

         return aircrafts;
      }

      public override String ToString()
      {
         StringBuilder sb = new StringBuilder();
         sb.Append("Profile: "+Name+"\n");
         sb.Append("Events:\n");
         foreach (ProfileEvent e in ProfileEvents)
         {
            sb.Append(e+"\n");
         }

         return sb.ToString();
      }

      public class ProfileEvent
      {
         public int Id { get; set; }
         public String Aircraft { get; set; }
         public String PrimaryCondition { get; set; }
         public Double PrimaryValue { get; set; }
         public String SecondaryCondition { get; set; }
         public Double SecondaryValue { get; set; }
         public LedColor ColorOn { get; set; } = LedColor.BLACK;
         public LedColor ColorFlashing { get; set; } = LedColor.BLACK;
         public int DeviceId { get; set; } = 0;
         public int LedNumber { get; set; } = 0;
         public String Description { get; set; }

         public ProfileEvent()
         {
            this.Id = 0;
            this.Aircraft = "";
            this.PrimaryCondition = "=";
            this.PrimaryValue = 0.0;
            this.SecondaryCondition = "";
            this.SecondaryValue = 0.0;
            this.ColorOn = LedColor.BLACK;
            this.ColorFlashing = LedColor.BLACK;
            this.DeviceId = 0;
            this.LedNumber = 0;
            this.Description = "";
         }

         public ProfileEvent(ProfileEvent entry)
         {
            this.Id = entry.Id;
            this.Aircraft = entry.Aircraft;
            this.PrimaryCondition =entry.PrimaryCondition;
            this.PrimaryValue = entry.PrimaryValue;
            this.SecondaryCondition = entry.SecondaryCondition;
            this.SecondaryValue = entry.SecondaryValue;
            this.ColorOn = entry.ColorOn;
            this.ColorFlashing = entry.ColorFlashing;
            this.DeviceId = entry.DeviceId;
            this.LedNumber = entry.LedNumber;
            this.Description = entry.Description;
         }


         public ProfileEvent(String aircraft, int id, String primaryCondition, double primaryValue, String secondaryCondition, double secondaryValue,  int deviceId, int ledNumber, LedColor colorOn, LedColor colorFlashing, String description)
         {
            this.Id = id;
            this.Aircraft = aircraft;
            this.PrimaryCondition = primaryCondition;
            this.PrimaryValue = primaryValue;
            this.SecondaryCondition = secondaryCondition;
            this.SecondaryValue = secondaryValue;
            this.ColorOn = colorOn;
            this.ColorFlashing = colorFlashing;
            this.DeviceId = deviceId;
            this.LedNumber = ledNumber;
            this.Description = description;
         }


         public override string ToString()
         {
            StringBuilder sb = new StringBuilder();
            sb.Append("[" + Aircraft + "] (" + Id + ") " + PrimaryCondition + PrimaryValue + " DEV:" + DeviceId + " LED:" + LedNumber + " ON:" + ColorOn + " FLASH:" + ColorFlashing);
            return sb.ToString();
         }

         internal bool IsStatic()
         {
            return PrimaryCondition.Equals("S");
         }

         public String GetConditionsAsString()
         {
            if (IsStatic()) return "STATIC";
            String result ="X " + PrimaryCondition + " " + PrimaryValue.ToString("0.00");
            if (SecondaryCondition!=null && SecondaryCondition.Length>0 && !SecondaryCondition.Equals("NONE") && !SecondaryCondition.Equals("-"))
            {
               result += " AND X " + SecondaryCondition + " " + SecondaryValue.ToString("0.00") ;
            }
            return result;
         }
      }
   }
}
