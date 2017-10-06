using System;

using Foundation;
using UIKit;

namespace App2_Collection
{
    public partial class cellView : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("cellView");
        public static readonly UINib Nib;

        static cellView()
        {
            Nib = UINib.FromName("cellView", NSBundle.MainBundle);
        }

        protected cellView(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        internal static cellView Create()
        {
            return (cellView)Nib.Instantiate(null, null)[0];
        }
    }
}