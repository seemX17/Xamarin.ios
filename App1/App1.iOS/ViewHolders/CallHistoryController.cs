using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace App1.iOS
{
    public partial class CallHistoryController : UITableViewController
    {
        public List<String> PhoneNumbers { get; set; }
         public static NSString callHistoryCellId = new NSString("CallHistoryCell");

        public CallHistoryController (IntPtr handle) : base (handle)
        {
            TableView.RegisterClassForCellReuse(typeof(UITableViewCell), callHistoryCellId);
            TableView.Source = new CallHistoryDataSource(this);
            PhoneNumbers = new List<string>();
        }
    }

    internal class CallHistoryDataSource : UITableViewSource
    {
        private CallHistoryController callHistoryController;

        public CallHistoryDataSource(CallHistoryController callHistoryController)
        {
            this.callHistoryController = callHistoryController;
        }
        // Returns the number of rows in each section of the table
        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return callHistoryController.PhoneNumbers.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(CallHistoryController.callHistoryCellId);

            int row = indexPath.Row;
            cell.TextLabel.Text = callHistoryController.PhoneNumbers[row];
            return cell;
        }
    }
}