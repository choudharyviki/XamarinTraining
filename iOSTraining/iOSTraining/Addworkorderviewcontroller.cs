using System;
using System.Collections.Generic;
using CoreGraphics;
using iOSTraining.Model;
using UIKit;
//using UIKit;

namespace iOSTraining
{
    public partial class Addworkorderviewcontroller : UIViewController
    {
        UIPickerView pickerName;
        private int changevalueofpicker;
        private UITextField tf;
        UIView notificationView;
        PeopleModel personModel;
        UIToolbar toolbar;
        string selectname;
        string selectWork;
        string selcetHobbies;
        bool pickerscroll=false;
        List<string> nameOfEmployee = new List<string>();
        List<string> workOfEmployee = new List<string>();
        List<string> hobbiesOfEmployee = new List<string>();

        public Addworkorderviewcontroller() : base("Addworkorderviewcontroller", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            nameOfEmployee.Add("Amy Burn");
            nameOfEmployee.Add("Kevin Mullians");
            nameOfEmployee.Add("craige Dunn");
            nameOfEmployee.Add("daivd Burn");
            nameOfEmployee.Add("mark Burn");
            nameOfEmployee.Add("Tom Burn");

            workOfEmployee.Add("Teacher");
            workOfEmployee.Add("Manager");
            workOfEmployee.Add("Engineer");
            workOfEmployee.Add("Farmer");
            workOfEmployee.Add("Business");
            workOfEmployee.Add("Inspector");

            hobbiesOfEmployee.Add("Cricket");
            hobbiesOfEmployee.Add("Football");
            hobbiesOfEmployee.Add("Hockey");
            hobbiesOfEmployee.Add("Sketching");
            hobbiesOfEmployee.Add("Painter");
            hobbiesOfEmployee.Add("Cooking");

            TitleValidation.Hidden = true;
            Descriptionvalidation.Hidden = true;
            Faclityvalidation.Hidden = true;
            UnitValidation.Hidden = true;
            Assignvalidation.Hidden = true;
            cancelbutton.Layer.BorderColor = UIColor.Blue.CGColor;
            cancelbutton.Layer.BorderWidth = 1;
            cancelbutton.Layer.CornerRadius = 15;
            Faclitytextbox.EditingDidBegin += CallFacilityDropDown;
            
            UITapGestureRecognizer tapGesture = new UITapGestureRecognizer(Tap);
            tapGesture.NumberOfTapsRequired = 1;
            View.AddGestureRecognizer(tapGesture);

            pickerName = new UIPickerView(new CGRect(UIScreen.MainScreen.Bounds.X - UIScreen.MainScreen.Bounds.Width,
           UIScreen.MainScreen.Bounds.Height - 230, UIScreen.MainScreen.Bounds.Width, 180));
           // personModel = new PeopleModel();
           // pickerName.Model = personModel;
           // personModel.Valuechange += CallWhenValueChange;

             toolbar = new UIToolbar(new CGRect(0, 0, 320, 44));
            UIBarButtonItem flexiblespaceleft = new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace, null, null);
            UIBarButtonItem donebutton = new UIBarButtonItem("Done", UIBarButtonItemStyle.Done, this, new ObjCRuntime.Selector("DoneAction"));
            donebutton.Clicked += DoneAction;
            UIBarButtonItem[] list = new UIBarButtonItem[] { flexiblespaceleft,donebutton  };
            toolbar.SetItems(list,false);
            Faclitytextbox.InputAccessoryView = toolbar;
            Unittextbox.InputAccessoryView = toolbar;
            Unittextbox.EditingDidBegin += CallFacilityDropDown;
            Assigntextbox.InputAccessoryView = toolbar;
            Assigntextbox.EditingDidBegin += CallFacilityDropDown;

            // Perform any additional setup after loading the view, typically from a nib.
        }

        

        private void DoneAction(object s ,EventArgs e)

        {
            if (!pickerscroll)
                {
                tf.Text = personModel.DefaultPickerValue();
                tf.ResignFirstResponder();
                }
                else
                {
                tf.Text = selectname;
                tf.ResignFirstResponder();

                }
        }

        private void CallWhenValueChange(object sender, EventArgs e)
        {
            pickerscroll = true;
           selectname= personModel.Selectedvalue; 
        }

        private void Tap()
        {
           
            if (string.IsNullOrWhiteSpace(TitleTextBox.Text))
            {
                TitleValidation.Hidden = false;
            }
            else
                TitleValidation.Hidden = true;


            if (string.IsNullOrWhiteSpace(Descriptiontextbox.Text))
            {
                Descriptionvalidation.Hidden = false;
            }
            else
                Descriptionvalidation.Hidden = true;
            if (string.IsNullOrWhiteSpace(Faclitytextbox.Text))
            {
                Faclityvalidation.Hidden = false;
            }
            else
                Faclityvalidation.Hidden = true;
            if (string.IsNullOrWhiteSpace(Unittextbox.Text))
            {
                UnitValidation.Hidden = false;
            }
            else
                UnitValidation.Hidden = true;

            if (string.IsNullOrWhiteSpace(Assigntextbox.Text))
            {
                Assignvalidation.Hidden = false;
            }
            else
                Assignvalidation.Hidden = true;


        }

        private void CallFacilityDropDown(object sender, EventArgs e)
        {
             tf = (UITextField)sender;
            List<string> list;
            if(tf.Tag==101)
            {
                list = nameOfEmployee;
            }
            else if(tf.Tag == 102)
            {
                list = workOfEmployee;
            }
            else
            {
                list = hobbiesOfEmployee;
            }
            personModel = new PeopleModel(list);
            pickerName.Model = personModel;
            personModel.Valuechange += CallWhenValueChange;

            tf.InputView = pickerName;
         
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

