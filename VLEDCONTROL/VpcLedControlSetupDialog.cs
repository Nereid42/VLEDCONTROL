using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VLEDCONTROL
{
   public partial class VpcLedControlSetupDialog : Form
   {
      private const String VPC_LED_CONTROL_EXE = "VPC_LED_Control.exe";
      private const String DEFAULT_VPC_SOFTWARE_INSTALL_PATH = "C:/Program Files (x86)/VPC Software Suite";

      public String VpcLedControlExePath { get; private set; }

      public VpcLedControlSetupDialog()
      {
         InitializeComponent();
      }

      private void buttonAutomatic_Click(object sender, EventArgs e)
      {
         // search in dfeualt installation first
         if(Directory.Exists(DEFAULT_VPC_SOFTWARE_INSTALL_PATH))
         {
            String exe = DEFAULT_VPC_SOFTWARE_INSTALL_PATH + "/tools/" + VPC_LED_CONTROL_EXE;
            if (File.Exists(exe))
            {
               VpcLedControlExePath = exe;
            }
            else
            {
               VpcLedControlExePath = Tools.ScanForFile(DEFAULT_VPC_SOFTWARE_INSTALL_PATH, VPC_LED_CONTROL_EXE);
            }
         }
         else
         {
            VpcLedControlExePath = Tools.ScanForFile(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), VPC_LED_CONTROL_EXE);
         }
      }

      private void buttonChooseFolder_Click(object sender, EventArgs e)
      {
         OpenFileDialog chooser = new OpenFileDialog();
         chooser.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
         chooser.Multiselect = false;
         chooser.Filter = "Executables (*.exe)|*.exe";
         chooser.FilterIndex = 1;
         chooser.RestoreDirectory = true;
         if (chooser.ShowDialog() == DialogResult.OK)
         {
            VpcLedControlExePath = chooser.FileName;
         }
      }
   }
}
