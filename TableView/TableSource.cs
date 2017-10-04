using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace TableView
{
    public class TableSource : UITableViewSource
    {
        string[] TableItems;
        string CellIdentifier = "TableCell";

        public TableSource(string[] items)
        {
            TableItems = items;
        }
        //returns data from the uitablecellview 
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath) //Inherited abstract class
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            string item = TableItems[indexPath.Row];
            
            //if there are non cell add cells
            if(cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier);
            }
            cell.TextLabel.Text = item;

            return cell;
           
        }

        //nint is astruct used to store number of rows
        public override nint RowsInSection(UITableView tableview, nint section)//Inherited abstract class
        {
            return TableItems.Length;
        }
    }
}