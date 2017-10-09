using ELCImagePicker;
using Foundation;
using System;
using System.Collections.Generic;
using UIKit;
//Permissions to be added to the info plist <key>NSPhotoLibraryUsageDescription</key> <string>New Entry</string>

namespace App3_Gallery
{
    public partial class ViewControllerT : UITableViewController
    {

        private List<AssetResult> mResults = new List<AssetResult>();//Asset result using elci image picker

        public ViewControllerT (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            
            var aButton = new UIBarButtonItem(UIBarButtonSystemItem.Add, (s, e) =>
            {
                //create a new instance of the picker view controller
                var picker = ELCImagePickerViewController.Create(15);

                picker.Completion.ContinueWith( t =>
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

                            TableView.ReloadData();

                        }
                    });
                });


                this.PresentViewController(picker, true, null);

            });


            this.NavigationItem.RightBarButtonItem = aButton;
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return mResults.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            const string cellIdentifier = "Cell";

            var cell = tableView.DequeueReusableCell(cellIdentifier);
            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
            }

            var asset = mResults[indexPath.Row];

            cell.ImageView.Image = asset.Image;
            cell.TextLabel.Text = asset.Name;

            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var asset = mResults[indexPath.Row];
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 100;
        }
    }
}
