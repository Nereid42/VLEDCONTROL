/* written 2021 byNereid
  
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLEDCONTROL
{
   public class NumericListViewSorter : System.Collections.IComparer
   {

      public int Compare(object left, object right)
      {
         if (!(left is ListViewItem)) return 0;
         if (!(right is ListViewItem)) return 0;

         ListViewItem litem = (ListViewItem)left;
         ListViewItem ritem = (ListViewItem)right;

         int lval = Tools.ToInt(litem.Text);
         int rval = Tools.ToInt(ritem.Text);

         return lval.CompareTo(rval);
      }
   }
}
