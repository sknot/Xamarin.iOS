using System;

using UIKit;

namespace MyFirstApp
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
            this.btnOtro.SetTitle("Cambio", UIControlState.Normal);
            this.btnOtro.TouchDown += (sender, e) => {
                System.Diagnostics.Debug.WriteLine("Hola mundo Programático!");
            };
        }

        partial void BtnPresioname_TouchUpInside(UIButton sender)
        {
            this.lblTexto.Text = this.tfEscribeAlgo.Text;
            this.btnOtro.SetTitle(this.tfEscribeAlgo.Text, UIControlState.Normal);
            this.tfEscribeAlgo.Text = string.Empty;

            System.Diagnostics.Debug.WriteLine("Hola Mundo desde Xamarin.iOS");
        }
    }
}