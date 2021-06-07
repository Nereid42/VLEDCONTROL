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
   public partial class EditMappingEntryDialog : Form
   {
      public Profile Profile;
      public Profile.MappingEntry MappingEntry;

      public EditMappingEntryDialog()
      {
         InitializeComponent();
         this.textBoxEventId.KeyPress += new KeyPressEventHandler(Tools.IntegerKeyPressed);
         this.comboBoxAircraft.TextChanged += new EventHandler(this.ComboBoxAircraftTextChanged);
      }

      public String GetAircraft()
      {
         return comboBoxAircraft.Text;
      }

      public String GetName()
      {
         return textBoxName.Text;
      }

      public int GetId()
      {
         return Tools.ToInt(textBoxEventId.Text);
      }

      private void EditMappingEntryDialog_Load(object sender, EventArgs e)
      {
         if (Profile == null) return;
         this.comboBoxAircraft.Items.Clear();
         foreach (String ac in Profile.GetAircraftList())
         {
            this.comboBoxAircraft.Items.Add(ac);
         }
         //
         if (MappingEntry != null)
         {
            this.textBoxEventId.Text = MappingEntry.Id.ToString();
            this.comboBoxAircraft.Text = MappingEntry.Aircraft;
            this.textBoxName.Text = MappingEntry.Name;
         }
         else
         {
            if (Profile.MappingEntries.Count>0)
            {
               Profile.MappingEntry lastEntry = Profile.MappingEntries.Last();
               this.comboBoxAircraft.Text = lastEntry.Aircraft;
               this.textBoxEventId.Text = (lastEntry.Id + 1).ToString();
            }
         }
         this.ActiveControl = textBoxName;
      }

      private void textBoxEventId_TextChanged(object sender, EventArgs e)
      {
         string nameOk = (MappingEntry != null) ? MappingEntry.Name : "";
         int idOk = (MappingEntry != null) ? MappingEntry.Id : -1;
         String name = textBoxName.Text;
         int id = Tools.ToInt(textBoxEventId.Text);
         if ( (id != idOk && VLED.Engine.CurrentProfile.ContainsMapping(comboBoxAircraft.Text, id)) 
         ||   (name != nameOk && VLED.Engine.CurrentProfile.ContainsMapping(comboBoxAircraft.Text, name)) )
         {
            buttonOk.Enabled = false;
         }
         else
         {
            buttonOk.Enabled = true;
         }
      }

      private void textBoxName_TextChanged(object sender, EventArgs e)
      {
         string nameOk = (MappingEntry != null) ? MappingEntry.Name : "";
         int idOk = (MappingEntry != null) ? MappingEntry.Id : -1;
         String name = textBoxName.Text;
         int id = Tools.ToInt(textBoxEventId.Text);
         if ((id != idOk && VLED.Engine.CurrentProfile.ContainsMapping(comboBoxAircraft.Text, id))
         || (name != nameOk && VLED.Engine.CurrentProfile.ContainsMapping(comboBoxAircraft.Text, name)) )
         {
            buttonOk.Enabled = false;
         }
         else
         {
            buttonOk.Enabled = true;
         }
      }
      private void ComboBoxAircraftTextChanged(Object o, EventArgs e)
      {
         string nameOk = (MappingEntry != null)?MappingEntry.Name:"";
         int idOk = (MappingEntry != null) ? MappingEntry.Id : -1;
         String name = textBoxName.Text;
         int id = Tools.ToInt(textBoxEventId.Text);
         if ( ( name != nameOk && VLED.Engine.CurrentProfile.ContainsMapping(comboBoxAircraft.Text, name))
         || (id != idOk && VLED.Engine.CurrentProfile.ContainsMapping(comboBoxAircraft.Text, id)) )
         {
            buttonOk.Enabled = false;
         }
         else
         {
            buttonOk.Enabled = true;
         }
      }

      private void comboBoxAircraft_SelectedIndexChanged(object sender, EventArgs e)
      {

      }
   }
}
