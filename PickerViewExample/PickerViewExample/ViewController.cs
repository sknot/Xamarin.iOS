using Foundation;
using System;

using UIKit;

namespace PickerViewExample
{
    public partial class ViewController : UIViewController,
        IUIPickerViewDataSource, IUIPickerViewDelegate
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            this.pvPiker.DataSource = this;
            this.pvPiker.Delegate = this;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
        #region IUIPickerViewDataSource
        public nint GetComponentCount(UIPickerView pickerView)
        {
            return 3;
        }

        public nint GetRowsInComponent(UIPickerView pickerView, nint component)
        {
            if (component == 0)
            {
                return 12;
            }
            else if (component == 1)
            {
                return 60;
            }
            else
            {
                return 2;
            }
        }

        [Export("PickerViewExampleView:titleForRow:forComónent:")]
        public string GetTitle(UIPickerView pickerView, nint row, nint component)
        {
            if (component == 0)
            {
                return "H: " + (row + 1);
            }
            else if (component == 1)
            {
                return "M: " + row;
            }
            else
            {
                if (row == 0)
                {
                    return "AM";
                }
                else {
                    return "PM";
                }
            }
        }
        #endregion

        #region IUIPickerViewDelegate
        [Export("pickerView:didSelectRow:inComponent:")]
        public void Selected(UIPickerView pickerView, nint row, nint component)
        {
            if (component == 0)
            {
                this.lblText.Text = "Selecciono: " + row;
            }
            else if (component == 1)
            {
                this.lblText.Text = "Selecciono: " + row;
            }
            else
            {
                if (row == 0)
                {
                    this.lblText.Text = "Selecciono: " + row;
                }
                else
                {
                    this.lblText.Text = "Selecciono: " + row;
                }
            }
        }
        #endregion
    }
}