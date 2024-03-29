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
      static String PreviousMappingName;

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
               // clipboard
               String clipboardData = Clipboard.GetText();
               if (clipboardData != null)
               {
                  textBoxName.Text = Tools.AlphaNumeric(clipboardData.ToUpper().Trim().Replace(' ', '_'));
               }
            }
         }
         // focus
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

      private void buttonCopyPrevious_Click(object sender, EventArgs e)
      {
         this.textBoxName.Text = EditMappingEntryDialog.PreviousMappingName;
         this.textBoxName.Focus();
         this.textBoxName.SelectionLength = 0;
      }

      private void buttonOk_Click(object sender, EventArgs e)
      {
         EditMappingEntryDialog.PreviousMappingName = this.textBoxName.Text;
      }

      private void buttonCurrentAircraft_Click(object sender, EventArgs e)
      {
         this.comboBoxAircraft.Text = VLED.MainWindow.textBoxAircraft.Text;
      }
   }
}
