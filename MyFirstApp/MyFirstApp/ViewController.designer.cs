// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace MyFirstApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnOtro { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnPresioname { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTexto { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tfEscribeAlgo { get; set; }

        [Action ("BtnPresioname_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnPresioname_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnOtro != null) {
                btnOtro.Dispose ();
                btnOtro = null;
            }

            if (btnPresioname != null) {
                btnPresioname.Dispose ();
                btnPresioname = null;
            }

            if (lblTexto != null) {
                lblTexto.Dispose ();
                lblTexto = null;
            }

            if (tfEscribeAlgo != null) {
                tfEscribeAlgo.Dispose ();
                tfEscribeAlgo = null;
            }
        }
    }
}