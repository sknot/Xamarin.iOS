using System;

using UIKit;

namespace Viewer
{
    public partial class SecondViewController : UIViewController
    {
        public SecondViewController(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }

        partial void BtnRegresar_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, ()=>{
                System.Diagnostics.Debug.WriteLine("Se oculto el second view controller");
            });
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            //La vista ya se encuentra creada y esta apunto de ser mostrado
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            //La vista ya esta creada y está mostrada
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            //La vista va a desaparecer
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
            //La vista ya se quito
        }
    }
}