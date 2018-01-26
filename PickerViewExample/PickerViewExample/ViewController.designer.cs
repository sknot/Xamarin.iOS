// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace PickerViewExample
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView pvPiker { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblText != null) {
                lblText.Dispose ();
                lblText = null;
            }

            if (pvPiker != null) {
                pvPiker.Dispose ();
                pvPiker = null;
            }
        }
    }
}