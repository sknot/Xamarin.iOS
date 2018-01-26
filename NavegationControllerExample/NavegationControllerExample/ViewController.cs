using System;
using Foundation;
using UIKit;

namespace NavegationControllerExample
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

        partial void UIBarButtonItem1029_Activated(UIBarButtonItem sender)
        {
            RedViewController destino = (RedViewController)this.Storyboard.InstantiateViewController("RedViewController");

            //Paso de variables
            destino.mensaje = "Hola Mundo";

            this.NavigationController.PushViewController(destino, true);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier.Equals("LineaNaranjaMorado"))
            {
                var destino = segue.DestinationViewController as MoradoViewController;

                destino.miDoble = 5.5;
            }
        }
    }
}