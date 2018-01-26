using System;
using Foundation;
using UIKit;

namespace CollectionsExample
{
    public partial class ViewController : UIViewController,
        IUITableViewDataSource, IUITableViewDelegate
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.tvTable.DataSource = this;
            this.tvTable.Delegate = this;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        #region IUITableViewDataSource
        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            String CellId;

            if (indexPath.Row % 2 == 0)
            {
                CellId = "cell";
            }
            else {
                CellId = "cell2";
            }

            var reusableCell = tableView.DequeueReusableCell(CellId);

            reusableCell.TextLabel.Text = "Celda: " + indexPath.Row;

            if (reusableCell.DetailTextLabel != null)
            {
                reusableCell.DetailTextLabel.Text = "Subtítulo: " + indexPath.Row;
            }

            return reusableCell;
        }

        public nint RowsInSection(UITableView tableView, nint section)
        {
            return 50;
        }
        #endregion

        #region IUITableViewDelegate
        [Export("tableView:didSelectRowAtIndexPath:")]
        public void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            System.Diagnostics.Debug.WriteLine("Presionó: " + indexPath.Row);
        }
        
        #endregion




    }
}