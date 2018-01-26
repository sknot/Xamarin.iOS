using Foundation;
using System;
using UIKit;

namespace NavegationControllerExample
{
    public partial class RedViewController : UIViewController
    {
        public String mensaje { get; set; }
        public RedViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            
        }

        partial void UIButton1631_TouchUpInside(UIButton sender)
        {
            this.NavigationController.PopViewController(true);
        }
    }
}