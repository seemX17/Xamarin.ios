// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace App4_GalleryC
{
    [Register ("CellView")]
    partial class CellView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView id_image { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel id_label { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (id_image != null) {
                id_image.Dispose ();
                id_image = null;
            }

            if (id_label != null) {
                id_label.Dispose ();
                id_label = null;
            }
        }
    }
}