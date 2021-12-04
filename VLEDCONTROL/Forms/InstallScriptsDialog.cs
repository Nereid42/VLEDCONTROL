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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace VLEDCONTROL
{
   public partial class InstallScriptsDialog : Form
   {
      public String BasePath;

      public InstallScriptsDialog()
      {
         InitializeComponent();
      }

      private void InstallScriptsDialog_Load(object sender, EventArgs e)
      {

      }

      private void buttonDcsRelease_Click(object sender, EventArgs e)
      {
         String userprofile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
         BasePath = userprofile + "\\" + "Saved Games"+"\\DCS";
      }

      private void buttonDcsOpenBeta_Click(object sender, EventArgs e)
      {
         String userprofile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
         BasePath = userprofile + "\\" + "Saved Games" + "\\DCS.openbeta";
      }

      private void buttonChooseFolder_Click(object sender, EventArgs e)
      {
         FolderBrowserDialog dialog = new FolderBrowserDialog();
         dialog.ShowNewFolderButton = false;
         dialog.Description = "Select Save Game Folder for DCS...";
         if (dialog.ShowDialog() == DialogResult.OK)
         {
            BasePath = dialog.SelectedPath;
         }
      }
   }
}
