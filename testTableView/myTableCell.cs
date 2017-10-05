using System;

using Foundation;
using UIKit;

namespace testTableView
{
    public partial class myTableCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("myTableCell");
        public static readonly UINib Nib;
       

        static myTableCell()
        {
            Nib = UINib.FromName("myTableCell", NSBundle.MainBundle);
        }

        protected myTableCell(IntPtr handle) : base(handle)
        {
            
            // Note: this .ctor should not contain any initialization logic.
        }

        public string label1txt { set { label1.Text = value; } }

        internal static UITableViewCell Create()
        {
            return (myTableCell)Nib.Instantiate(null, null)[0];
        }
    }
}
