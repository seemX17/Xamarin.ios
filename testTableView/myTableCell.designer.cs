﻿// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace testTableView
{
    [Register ("myTableCell")]
    partial class myTableCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imageView1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel label1 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imageView1 != null) {
                imageView1.Dispose ();
                imageView1 = null;
            }

            if (label1 != null) {
                label1.Dispose ();
                label1 = null;
            }
        }
    }
}