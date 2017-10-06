using System;
using Foundation;
using UIKit;

namespace App2_Collection
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            id_collection.BackgroundColor = UIColor.White;
            id_collection.RegisterNibForCell(UINib.FromName("cellView", null), cellView.Key);
            id_collection.DataSource = new Datasrc();
           
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }

    public class Datasrc : UICollectionViewDataSource
    {

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            cellView cell = (cellView)collectionView.DequeueReusableCell(cellView.Key, indexPath);


            return cell;
        }

       

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return 10;
        }
    }
}