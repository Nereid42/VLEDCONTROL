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
