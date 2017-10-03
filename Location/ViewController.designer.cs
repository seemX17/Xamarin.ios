// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Location
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LblAltitude { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LblCourse { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LblLatitude { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LblLongitude { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LblSpeed { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LblAltitude != null) {
                LblAltitude.Dispose ();
                LblAltitude = null;
            }

            if (LblCourse != null) {
                LblCourse.Dispose ();
                LblCourse = null;
            }

            if (LblLatitude != null) {
                LblLatitude.Dispose ();
                LblLatitude = null;
            }

            if (LblLongitude != null) {
                LblLongitude.Dispose ();
                LblLongitude = null;
            }

            if (LblSpeed != null) {
                LblSpeed.Dispose ();
                LblSpeed = null;
            }
        }
    }
}