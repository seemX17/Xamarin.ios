using System;
using Foundation;
using UIKit;

namespace testTableView
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            mytableView1.BackgroundColor = UIColor.Black;
            mytableView1.RegisterNibForCellReuse(UINib.FromName("myTableCell", null), myTableCell.Key);
            string[] tableItems = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
            mytableView1.Source = new Datasrc(tableItems);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }

    public class Datasrc : UITableViewSource
    {
        string[] TableItems;

        public Datasrc(string[] tableItems)
        {
            TableItems = tableItems;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            myTableCell cell = (myTableCell)tableView.DequeueReusableCell(myTableCell.Key);
           
            string item = TableItems[indexPath.Row];

            //---- if there are no cells to reuse, create a new one
            if (cell == null)
            {  cell = (myTableCell)myTableCell.Create(); }
            cell.label1txt = item;
            return cell;

        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            // return 5;
            return TableItems.Length;
        }
        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 150 ;

        }
    }
}