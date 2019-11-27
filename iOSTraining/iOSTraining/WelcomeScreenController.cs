using Foundation;
using System;
using UIKit;

namespace iOSTraining
{
    public partial class WelcomeScreenController : UIViewController
    {
        public WelcomeScreenController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
           // LoginLabel.Text = "Hello, " + UserName;

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        
    }
}