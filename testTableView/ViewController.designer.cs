// WARNING
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
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        testTableView.myTableView mytableView1 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (mytableView1 != null) {
                mytableView1.Dispose ();
                mytableView1 = null;
            }
        }
    }
}