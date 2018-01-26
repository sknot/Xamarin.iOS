using System;

using UIKit;

namespace Viewer
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void BtnNavegar_TouchUpInside(UIButton sender)
        {
            var viewController = this.Storyboard.InstantiateViewController("SecondViewController");

            this.PresentViewController(viewController, true, () =>
            {
                System.Diagnostics.Debug.WriteLine("Se presento el second view controller");
            });
        }
    }
}