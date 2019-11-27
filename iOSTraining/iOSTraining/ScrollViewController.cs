using Foundation;
using System;
using UIKit;

namespace iOSTraining
{
    public partial class ScrollViewController : UIViewController
    {
        public ScrollViewController (IntPtr handle) : base (handle)
        {
        }
        public ScrollViewController() : base("ScrollViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
           // var scrollView = new UIScrollView();
           // View.Add(scrollView);
           // scrollView.TranslatesAutoresizingMaskIntoConstraints = false;

           // NSLayoutConstraint.Create(scrollView, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, View, NSLayoutAttribute.Leading, 1.0f, 30).Active = true;
           // NSLayoutConstraint.Create(scrollView, NSLayoutAttribute.Top, NSLayoutRelation.Equal, View, NSLayoutAttribute.Top, 1.0f, 100).Active = true;
           // NSLayoutConstraint.Create(scrollView, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 800).Active = true;
           // NSLayoutConstraint.Create(scrollView, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 600).Active = true;

           //var btn = new UIButton();
           //// previousbtn = btn;
           // // nextbtn1 = btn;
           // btn.TranslatesAutoresizingMaskIntoConstraints = false;
           // btn.SetTitle("Button1", UIControlState.Normal);
           // btn.BackgroundColor = UIColor.Red;
           // scrollView.Add(btn);
           // NSLayoutConstraint.Create(btn, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, scrollView, NSLayoutAttribute.Leading, 1.0f, 30).Active = true;
           // NSLayoutConstraint.Create(btn, NSLayoutAttribute.Top, NSLayoutRelation.Equal, scrollView, NSLayoutAttribute.Top, 1.0f, 100).Active = true;
           // NSLayoutConstraint.Create(btn, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 40).Active = true;
           // NSLayoutConstraint.Create(btn, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 90).Active = true;

        }
    }
}