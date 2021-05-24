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
      }

      private void textBoxEventId_TextChanged(object sender, EventArgs e)
      {
         int idOk = (MappingEntry != null) ? MappingEntry.Id : -1;
         int id = Tools.ToInt(textBoxEventId.Text);
         if ( id != idOk && VLED.Engine.CurrentProfile.ContainsMapping(comboBoxAircraft.Text, id) )
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
         String name = textBoxName.Text;
         if (name != nameOk && VLED.Engine.CurrentProfile.ContainsMapping(comboBoxAircraft.Text, name) )
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
