using System;
using Foundation;
using UIKit;
using System.Collections.Generic;
using System.Linq;

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
            //var image = new Image { Source = "img1.jpg" };
            mytableView1.BackgroundColor = UIColor.Black;
            mytableView1.RegisterNibForCellReuse(UINib.FromName("myTableCell", null), myTableCell.Key);
            //string[] tableItems = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
            List<imageList> images = new List<imageList>();
            images.Add(new imageList { pictures="img1.jpg",name = "Vegetables" });
            images.Add(new imageList { pictures = "img2.jpg", name = "Fruits" });
            images.Add(new imageList { pictures = "img3.jpg", name = "Flower Buds" });
            images.Add(new imageList { pictures = "img4.jpg", name = "Legumes" });
            images.Add(new imageList { pictures = "img5.jpg", name = "Bulbs" });
            images.Add(new imageList { pictures = "img2.jpg", name = "Tubers" });

            ImageviewMain.Image = UIImage.FromFile("Images/img1.jpg");

            mytableView1.Source = new Datasrc(images);
            // Perform any additional setup after loading the view, typically from a nib.
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }

    public  class imageList
    {
        public string pictures { get; set; }
        public string name { get; set; }
    }

    public class Datasrc : UITableViewSource
    {
        private List<imageList> images;

        

        public Datasrc(List<imageList> images)
        {
            this.images = images;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            myTableCell cell = (myTableCell)tableView.DequeueReusableCell(myTableCell.Key);


            //---- if there are no cells to reuse, create a new one
            if (cell == null)
            {  cell = (myTableCell)myTableCell.Create(); }
           cell.label1txt = images.ElementAt(indexPath.Row).name;
            cell.ImageImg = images.ElementAt(indexPath.Row).pictures;
            return cell;

        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            // return 5;
            return images.Count;
        }
        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 150 ;

        }
    }
}