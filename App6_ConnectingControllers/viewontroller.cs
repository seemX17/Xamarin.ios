using Foundation;
using System;
using UIKit;

namespace App6_ConnectingControllers
{
    public partial class viewontroller : UITableViewController
    {
        public viewontroller (IntPtr handle) : base (handle)
        {
        }
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            base.RowSelected(tableView, indexPath);
        }
    }
}