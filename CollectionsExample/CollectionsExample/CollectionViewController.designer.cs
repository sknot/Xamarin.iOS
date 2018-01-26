// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CollectionsExample
{
    [Register ("CollectionViewController")]
    partial class CollectionViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UICollectionView cvCollection { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (cvCollection != null) {
                cvCollection.Dispose ();
                cvCollection = null;
            }
        }
    }
}