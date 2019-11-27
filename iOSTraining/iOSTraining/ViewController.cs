using Foundation;
using System;
using UIKit;

namespace iOSTraining
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

        partial void ShowBtn_TouchUpInside(UIButton sender)
        {
            string name= NameText.Text;
            string password = PasswordText.Text;
               // LoginSuccessLabel.Text = "Login Successfully";
                PerformSegue("LoginScreenSuccess", this);
        }
        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            if (segue.Identifier.Equals("LoginScreenSuccess"))
            {

                var callsecondcontroller = (secondviewcontroller)segue.DestinationViewController;
                callsecondcontroller.UserName = NameText.Text;
            }

        }
    }
}