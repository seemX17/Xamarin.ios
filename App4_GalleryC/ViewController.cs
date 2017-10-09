using ELCImagePicker;
using System;
using System.Collections.Generic;
using UIKit;
using Foundation;
using CoreGraphics;

namespace App4_GalleryC
{
    public partial class ViewController : UIViewController
    {
        public static List<AssetResult> mResults = new List<AssetResult>();//Asset result using elci image picker

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            id_CollectionView.BackgroundColor = UIColor.White;
            id_CollectionView.RegisterNibForCell(UINib.FromName("CellView", null), CellView.Key);
            id_CollectionView.DataSource = new dataSrc();

            var aButton = new UIBarButtonItem(UIBarButtonSystemItem.Add, (s, e) =>
            {
                //create a new instance of the picker view controller
                var picker = ELCImagePickerViewController.Create(15);

                picker.Completion.ContinueWith(t =>
                {
                    //execute any UI code on the UI thread
                    this.BeginInvokeOnMainThread(() =>
                    {
                        //dismiss the picker
                        picker.DismissViewController(true, null);

                        if (t.IsCanceled || t.Exception != null)
                        {
                            //cancelled or error
                        }
                        else
                        {
                            //get the selected items
                            var items = t.Result as List<AssetResult>;

                            foreach (AssetResult aItem in items)
                            {
                                mResults.Add(aItem);
                            }

                            id_CollectionView.ReloadData();

                        }
                    });
                });


                this.PresentViewController(picker, true, null);

            });


            this.NavigationItem.RightBarButtonItem = aButton;
        }
      
    }

    public class dataSrc : UICollectionViewDataSource
    {
        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            // const string cellIdentifier = "Cell";
            CellView cell = (CellView)collectionView.DequeueReusableCell(CellView.Key, indexPath);
            var asset = ViewController.mResults[indexPath.Row];

            cell.ImageView = asset.Image;
            cell.TextLabel = asset.Name;

            return cell;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return ViewController.mResults.Count;
        }
    }
}