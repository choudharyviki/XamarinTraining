using System;
using CoreGraphics;
using UIKit;

namespace iOSTraining
{
    public partial class WelcomeViewController : UIViewController
    {
        UIScrollView scrollview;
        UIImageView myimage;
        int pos = 0;
        public WelcomeViewController() : base("WelcomeViewController", null)
        {
        }

        public WelcomeViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //scrollview = new UIScrollView(new CGRect(0, 0, View.Frame.Width, 500));
            //View.AddSubview(scrollview);
            //myimage = new UIImageView(UIImage.FromFile("abc.jpg"));
            //scrollview.ContentSize = new CGSize(300, 800);
            
            //for (int i = 0; i < 10; i++)
            //{
            //    var button = new UIButton();
            //    button.SetTitle("ButtonOne", UIControlState.Normal);
            //    button.SetTitleColor(UIColor.Black, UIControlState.Normal);
            //    button.Frame = new CGRect(25, 25, 300, 300+pos);
            //    pos += 80;
            //    scrollview.AddSubview(button);
            //}
           // scrollview.AddSubview(myimage);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton14449_TouchUpInside(UIButton sender)
        {
            PerformSegue("GalleryScreen", this);
        }

        partial void UIButton14759_TouchUpInside(UIButton sender)
        {
            PerformSegue("AllControlSegue", this);
        }
    }
}

