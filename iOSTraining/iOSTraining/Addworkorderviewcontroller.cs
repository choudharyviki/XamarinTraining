using System;
using CoreGraphics;
using iOSTraining.Model;
using UIKit;

namespace iOSTraining
{
    public partial class Addworkorderviewcontroller : UIViewController
    {
        UIPickerView pickerName;
        private int changevalueofpicker;
        UIView notificationView;
        public Addworkorderviewcontroller() : base("Addworkorderviewcontroller", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            cancelbutton.Layer.BorderColor = UIColor.Blue.CGColor;
            cancelbutton.Layer.BorderWidth = 1;
            cancelbutton.Layer.CornerRadius = 15;
            Faclitytextbox.EditingDidBegin += CallFacilityDropDown;

            // Perform any additional setup after loading the view, typically from a nib.
        }

        private void CallFacilityDropDown(object sender, EventArgs e)
        {
            pickerName = new UIPickerView(new CGRect(UIScreen.MainScreen.Bounds.X - UIScreen.MainScreen.Bounds.Width,
              UIScreen.MainScreen.Bounds.Height - 230, UIScreen.MainScreen.Bounds.Width, 180));
            var personModel = new PeopleModel();
            pickerName.Model = personModel;
            Faclitytextbox.Text= pickerName.SelectedRowInComponent(0).ToString();
            pickerName.TranslatesAutoresizingMaskIntoConstraints = false;
            View.Add(pickerName);
            NSLayoutConstraint.Create(pickerName, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, View, NSLayoutAttribute.Leading, 1.0f, -50).Active = true;
            NSLayoutConstraint.Create(pickerName, NSLayoutAttribute.Top, NSLayoutRelation.Equal, Faclitytextbox, NSLayoutAttribute.Top, 1.0f, -70).Active = true;
            // NSLayoutConstraint.Create(pickerName, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 40).Active = true;
            //  NSLayoutConstraint.Create(pickerName, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 90).Active = true;

        }
        public Addworkorderviewcontroller(IntPtr handle) : base(handle)
        {
        }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton473730_TouchUpInside(UIButton sender)
        {
            notificationView = new UIView();
            var notificationpopup = new UIView();
            var label = new UILabel();
            var closeBtn = new UIButton();
            closeBtn.AddTarget(ClosePopupMenu, UIControlEvent.TouchUpInside);
            closeBtn.SetTitleColor(UIColor.Black, UIControlState.Normal);
            closeBtn.SetTitle("Close", UIControlState.Normal);
            closeBtn.TranslatesAutoresizingMaskIntoConstraints = false;
            //closeBtn.Title("Close",UIControlState.Normal);
            notificationpopup.Layer.CornerRadius = 10;
            View.Add(notificationView);
            notificationView.Add(notificationpopup);
            notificationpopup.Add(label);
            notificationpopup.Add(closeBtn);
            notificationpopup.BackgroundColor = UIColor.White;
            notificationView.BackgroundColor = UIColor.FromWhiteAlpha(0.5f,0.5f);
            notificationView.TranslatesAutoresizingMaskIntoConstraints = false;
            notificationpopup.TranslatesAutoresizingMaskIntoConstraints = false;
            label.TranslatesAutoresizingMaskIntoConstraints = false;
            label.Text = "Notifications";
            NSLayoutConstraint.Create(notificationView, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, View, NSLayoutAttribute.Leading, 1, 10).Active = true;
            NSLayoutConstraint.Create(notificationView, NSLayoutAttribute.Top, NSLayoutRelation.Equal, View, NSLayoutAttribute.Top, 1, 80).Active = true;
            NSLayoutConstraint.Create(View, NSLayoutAttribute.Trailing, NSLayoutRelation.Equal, notificationView, NSLayoutAttribute.Trailing, 1, 10).Active = true;
            NSLayoutConstraint.Create(View, NSLayoutAttribute.Bottom, NSLayoutRelation.Equal, notificationView, NSLayoutAttribute.Bottom, 1, 10).Active = true;


            NSLayoutConstraint.Create(notificationpopup, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, notificationView, NSLayoutAttribute.Leading, 1, 30).Active = true;
            NSLayoutConstraint.Create(notificationpopup, NSLayoutAttribute.Top, NSLayoutRelation.Equal, notificationView, NSLayoutAttribute.Top, 1, 100).Active = true;
            NSLayoutConstraint.Create(notificationView, NSLayoutAttribute.Trailing, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Trailing, 1, 30).Active = true;
            NSLayoutConstraint.Create(notificationView, NSLayoutAttribute.Bottom, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Bottom, 1, 500).Active = true;




            NSLayoutConstraint.Create(label, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Leading, 1, 30).Active = true;
            NSLayoutConstraint.Create(label, NSLayoutAttribute.Top, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Top, 1, 40).Active = true;

            NSLayoutConstraint.Create(closeBtn, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Leading, 1, 270).Active = true;
            NSLayoutConstraint.Create(closeBtn, NSLayoutAttribute.Top, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Top, 1, 10).Active = true;
            //  NSLayoutConstraint.Create(closeBtn, NSLayoutAttribute.Width, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Width, 1, 60).Active = true;
            // NSLayoutConstraint.Create(closeBtn, NSLayoutAttribute.Height, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Height, 1, 40).Active = true;

        }

        private void ClosePopupMenu(object sender, EventArgs e)
        {
            notificationView.RemoveFromSuperview();
        }
    
    }
}

