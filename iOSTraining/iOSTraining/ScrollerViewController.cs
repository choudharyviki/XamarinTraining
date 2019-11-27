using Foundation;
using System;
using UIKit;

namespace iOSTraining
{
    public partial class ScrollerViewController : UIViewController
    {
        UIScrollView scrollView;
       // UIButton btn;
        int c = 40;

        public ScrollerViewController(IntPtr handle) : base(handle)
        {
        }
        public ScrollerViewController() : base("ScrollerViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            scrollView = new UIScrollView();

        scrollView.TranslatesAutoresizingMaskIntoConstraints = false;
            // btn.SetTitle("Button1", UIControlState.Normal);
            // btn.BackgroundColor = UIColor.Red;
            scrollView.ContentSize=new CoreGraphics.CGSize (600, 2000);
            View.Add(scrollView);
            NSLayoutConstraint.Create(scrollView, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, View, NSLayoutAttribute.Leading, 1.0f, 30).Active = true;
            NSLayoutConstraint.Create(scrollView, NSLayoutAttribute.Top, NSLayoutRelation.Equal, View, NSLayoutAttribute.Top, 1.0f, 100).Active = true;
            NSLayoutConstraint.Create(scrollView, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 1000).Active = true;
            NSLayoutConstraint.Create(scrollView, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 600).Active = true;
            for (int i = 0; i < 30; i++)
            {
                c +=60;

                var btn = new UIButton();
                    btn.TranslatesAutoresizingMaskIntoConstraints = false;
                    btn.SetTitle("Button1", UIControlState.Normal);
                    btn.BackgroundColor = UIColor.Red;
                    scrollView.Add(btn);
                    NSLayoutConstraint.Create(btn, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, scrollView, NSLayoutAttribute.Leading, 1.0f, 30).Active = true;
                    NSLayoutConstraint.Create(btn, NSLayoutAttribute.Top, NSLayoutRelation.Equal, scrollView, NSLayoutAttribute.Top, 1.0f, c).Active = true;
                    NSLayoutConstraint.Create(btn, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 40).Active = true;
                    NSLayoutConstraint.Create(btn, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 90).Active = true;
                
            }
        }
    }
    }