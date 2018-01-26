using Foundation;
using System;
using UIKit;

namespace CollectionsExample
{
    public partial class CollectionViewController : UIViewController,
        IUICollectionViewDataSource, IUICollectionViewDelegate 
    {
        public CollectionViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.cvCollection.DataSource = this;
            this.cvCollection.Delegate = this;
        }

        public UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            throw new NotImplementedException();
        }

        public nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return 50;
        }
    }
}