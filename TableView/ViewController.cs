using System;

using UIKit;

namespace TableView
{
    public partial class ViewController : UIViewController
    {
        private UITableView table;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            table = new UITableView(View.Bounds);//defaults to plain style
            string[] tableItems = new string[] { "Vegetables", "Fruits", "Flowers", "Bulbs", "Legumes", "test", "test2", "test3", };
            table.Source = new TableSource(tableItems);
            Add(table);
            //UITableView table;
            //table = new UITableView { Frame = new CoreGraphics.CGRect(0, 0, View.Bounds.Width, View.Bounds.Height)};
            //View.AddSubview(table);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}