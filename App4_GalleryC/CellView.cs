using System;

using Foundation;
using UIKit;

namespace App4_GalleryC
{
    public partial class CellView : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("CellView");
        public static readonly UINib Nib;

        static CellView()
        {
            Nib = UINib.FromName("CellView", NSBundle.MainBundle);
        }

        protected CellView(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public UIImage ImageView { set { id_image.Image = value ; } }
        public string TextLabel { set { id_label.Text = value; } }
    }
}