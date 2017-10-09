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
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UICollectionView id_CollectionView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (id_CollectionView != null) {
                id_CollectionView.Dispose ();
                id_CollectionView = null;
            }
        }
    }
}