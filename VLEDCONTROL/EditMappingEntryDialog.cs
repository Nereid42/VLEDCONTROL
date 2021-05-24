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
   }
}
