using CustomTableView.Model;
using Foundation;
using System;
using UIKit;

namespace CustomTableView
{
    public partial class itemTable : UITableViewCell
    { 
        public State Model { get; set; }

        public static readonly UINib NIb = UINib.FromName("itemTable", NSBundle.MainBundle);
        public static readonly NSString Key = new NSString("itemTable");

        public itemTable(IntPtr handle) : base (handle)
        {

        }

        public static itemTable Create()
        {
            return (itemTable)NIb.Instantiate(null, null)[0];
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            this.itemLabel.Text = Model.Name;
            this.itemImage.Image=UIImage.FromBundle(Model.Image);
        }

    }
}

