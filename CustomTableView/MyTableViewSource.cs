using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using CustomTableView.Model;

namespace CustomTableView
{
    class MyTableViewSource : UITableViewSource
    {
        private readonly List<State> _states;

        public MyTableViewSource(List<State> _states)
        {

            this._states = _states;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _states.Count();
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var states = _states[indexPath.Row];
            var cell = (itemTable)tableView.DequeueReusableCell(itemTable.Key);
            if (cell == null)
            {
                cell = itemTable.Create();
            }
            cell.Model = states;

            return cell;
        }
        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 130;
        }

       

    }
}