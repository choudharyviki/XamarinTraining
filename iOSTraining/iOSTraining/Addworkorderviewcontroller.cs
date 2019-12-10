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
        UIButton NotstartedBtn;
        UIButton ProgressBtn   ;
        UIButton OnholeBtn   ;
        UIButton CompleteBtn  ;
        UIButton LowBtn ;
        UIButton MediumBtn ;
        UIButton highBtn  ;
        UIButton FilterBtn ;
        string selectname;
        string selectWork;
        string selcetHobbies;
        bool pickerscroll=false;
        List<string> nameOfEmployee = new List<string>();
        List<string> workOfEmployee = new List<string>();
        List<string> hobbiesOfEmployee = new List<string>();
        bool select=true;
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
        private void ResetData(object sender, EventArgs e)
        {
            //comming soon
        }
        private void BackgroundColorCHange(object sender, EventArgs e)
        {
            var btn = sender as UIButton;
            Tuple<UIImage,UIColor> properties= !btn.Selected? new Tuple<UIImage,UIColor> (UIImage.FromBundle("right"),UIColor.Blue): new Tuple<UIImage,UIColor> (UIImage.FromBundle(""),UIColor.White);
            btn.SetBackgroundImage(properties.Item1, UIControlState.Normal);
            btn.BackgroundColor = properties.Item2;
            btn.Selected = !btn.Selected;
        }

        partial void UIButton473738_TouchUpInside(UIButton sender)
        {
            notificationView = new UIView();
            var notificationpopup = new UIView();
           

            var StatusLabel = new UILabel();
            var NotStaredLabel = new UILabel();
            var InProgessLabel = new UILabel();
            var OnHoldLabel = new UILabel();
            var CompleteLabel = new UILabel();
            var PriorityLabel = new UILabel();
            var LowLabel = new UILabel();
            var MediumLabel = new UILabel();
            var HighLabel = new UILabel();

            var CloseBtn = new UIButton();
            var ResetBtn = new UIButton();
            NotstartedBtn = new UIButton();
            ProgressBtn = new UIButton();
            OnholeBtn = new UIButton();
            CompleteBtn = new UIButton();
            LowBtn = new UIButton();
            MediumBtn = new UIButton();
            highBtn = new UIButton();
            FilterBtn = new UIButton();

            NotstartedBtn.AddTarget(BackgroundColorCHange, UIControlEvent.TouchUpInside);
            ProgressBtn.AddTarget(BackgroundColorCHange, UIControlEvent.TouchUpInside);
            OnholeBtn.AddTarget(BackgroundColorCHange, UIControlEvent.TouchUpInside);
            CompleteBtn.AddTarget(BackgroundColorCHange, UIControlEvent.TouchUpInside);
            LowBtn.AddTarget(BackgroundColorCHange, UIControlEvent.TouchUpInside);
            MediumBtn.AddTarget(BackgroundColorCHange, UIControlEvent.TouchUpInside);
            highBtn.AddTarget(BackgroundColorCHange, UIControlEvent.TouchUpInside);


            ResetBtn.AddTarget(ResetData, UIControlEvent.TouchUpInside);
            ResetBtn.SetTitleColor(UIColor.Black, UIControlState.Normal);
            ResetBtn.SetTitle("Reset", UIControlState.Normal);
            ResetBtn.TranslatesAutoresizingMaskIntoConstraints = false;

            CloseBtn.AddTarget(ClosePopupMenu, UIControlEvent.TouchUpInside);
            CloseBtn.SetTitleColor(UIColor.Black, UIControlState.Normal);
            CloseBtn.SetTitle("Close", UIControlState.Normal);
            CloseBtn.TranslatesAutoresizingMaskIntoConstraints = false;
            StatusLabel.TranslatesAutoresizingMaskIntoConstraints = false;

            notificationpopup.Add(ResetBtn);
            notificationpopup.Add(CloseBtn);

            notificationpopup.Add(NotstartedBtn);
            notificationpopup.Add(ProgressBtn);
            notificationpopup.Add(OnholeBtn);
            notificationpopup.Add(CompleteBtn);
            notificationpopup.Add(LowBtn);
            notificationpopup.Add(MediumBtn);
            notificationpopup.Add(highBtn);
            notificationpopup.Add(FilterBtn);

            NotstartedBtn.TranslatesAutoresizingMaskIntoConstraints = false;
            NotstartedBtn.Layer.CornerRadius = 5;
            NotstartedBtn.Layer.BorderWidth = 1;
            NotstartedBtn.Layer.BorderColor = UIColor.LightGray.CGColor;


            ProgressBtn.TranslatesAutoresizingMaskIntoConstraints = false;
            ProgressBtn.Layer.CornerRadius = 5;
            ProgressBtn.Layer.BorderWidth = 1;
            ProgressBtn.Layer.BorderColor = UIColor.LightGray.CGColor;


            OnholeBtn.TranslatesAutoresizingMaskIntoConstraints = false;
            OnholeBtn.Layer.CornerRadius = 5;
            OnholeBtn.Layer.BorderWidth = 1;
            OnholeBtn.Layer.BorderColor = UIColor.LightGray.CGColor;

            CompleteBtn.TranslatesAutoresizingMaskIntoConstraints = false;
            CompleteBtn.Layer.CornerRadius = 5;
            CompleteBtn.Layer.BorderWidth = 1;
            CompleteBtn.Layer.BorderColor = UIColor.LightGray.CGColor;

            LowBtn.TranslatesAutoresizingMaskIntoConstraints = false;
            LowBtn.Layer.CornerRadius = 5;
            LowBtn.Layer.BorderWidth = 1;
            LowBtn.Layer.BorderColor = UIColor.LightGray.CGColor;

            MediumBtn.TranslatesAutoresizingMaskIntoConstraints = false;
            MediumBtn.Layer.CornerRadius = 5;
            MediumBtn.Layer.BorderWidth = 1;
            MediumBtn.Layer.BorderColor = UIColor.LightGray.CGColor;

            highBtn.TranslatesAutoresizingMaskIntoConstraints = false;
            highBtn.Layer.CornerRadius = 5;
            highBtn.Layer.BorderWidth = 1;
            highBtn.Layer.BorderColor = UIColor.LightGray.CGColor;

            FilterBtn.TranslatesAutoresizingMaskIntoConstraints = false;
            FilterBtn.Layer.CornerRadius = 30;
            FilterBtn.Layer.BackgroundColor = UIColor.Red.CGColor;
            FilterBtn.SetTitle("Apply FIlter", UIControlState.Normal);
            FilterBtn.SetTitleColor(UIColor.White, UIControlState.Normal);

            StatusLabel.Text = "Status as";
            StatusLabel.Font = UIFont.BoldSystemFontOfSize(16);
            PriorityLabel.Font = UIFont.BoldSystemFontOfSize(16);
            NotStaredLabel.Text = "Not Started";
            InProgessLabel.Text = "In Porgress";
            OnHoldLabel.Text = "On Hold";
            CompleteLabel.Text = "Complete";
            PriorityLabel.Text = "Priority as";
            LowLabel.Text = "Low";
            MediumLabel.Text = "Medium";
            HighLabel.Text = "High";

            NotStaredLabel.TranslatesAutoresizingMaskIntoConstraints = false;
            InProgessLabel.TranslatesAutoresizingMaskIntoConstraints = false;
            OnHoldLabel.TranslatesAutoresizingMaskIntoConstraints = false;
            CompleteLabel.TranslatesAutoresizingMaskIntoConstraints = false;
            PriorityLabel.TranslatesAutoresizingMaskIntoConstraints = false;
            LowLabel.TranslatesAutoresizingMaskIntoConstraints = false;
            MediumLabel.TranslatesAutoresizingMaskIntoConstraints = false;
            HighLabel.TranslatesAutoresizingMaskIntoConstraints = false;

            notificationpopup.Add(StatusLabel);
            notificationpopup.Add(NotStaredLabel);
            notificationpopup.Add(InProgessLabel);
            notificationpopup.Add(OnHoldLabel);
            notificationpopup.Add(CompleteLabel);
            notificationpopup.Add(PriorityLabel);
            notificationpopup.Add(LowLabel);
            notificationpopup.Add(MediumLabel);
            notificationpopup.Add(HighLabel);

            notificationpopup.Layer.CornerRadius = 20;
            View.Add(notificationView);
            notificationView.Add(notificationpopup);

            notificationpopup.BackgroundColor = UIColor.White;
            notificationView.BackgroundColor = UIColor.FromWhiteAlpha(0.5f, 0.5f);
            notificationView.TranslatesAutoresizingMaskIntoConstraints = false;
            notificationpopup.TranslatesAutoresizingMaskIntoConstraints = false;

            NSLayoutConstraint.Create(notificationView, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, View, NSLayoutAttribute.Leading, 1, 10).Active = true;
            NSLayoutConstraint.Create(notificationView, NSLayoutAttribute.Top, NSLayoutRelation.Equal, View, NSLayoutAttribute.Top, 1, 80).Active = true;
            NSLayoutConstraint.Create(View, NSLayoutAttribute.Trailing, NSLayoutRelation.Equal, notificationView, NSLayoutAttribute.Trailing, 1, 10).Active = true;
            NSLayoutConstraint.Create(View, NSLayoutAttribute.Bottom, NSLayoutRelation.Equal, notificationView, NSLayoutAttribute.Bottom, 1, 10).Active = true;


            NSLayoutConstraint.Create(notificationpopup, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, notificationView, NSLayoutAttribute.Leading, 1, 30).Active = true;
            NSLayoutConstraint.Create(notificationpopup, NSLayoutAttribute.Top, NSLayoutRelation.Equal, notificationView, NSLayoutAttribute.Top, 1, 80).Active = true;
            NSLayoutConstraint.Create(notificationView, NSLayoutAttribute.Trailing, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Trailing, 1, 30).Active = true;
            NSLayoutConstraint.Create(notificationView, NSLayoutAttribute.Bottom, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Bottom, 1, 80).Active = true;


            NSLayoutConstraint.Create(CloseBtn, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Leading, 1, 30).Active = true;
            NSLayoutConstraint.Create(CloseBtn, NSLayoutAttribute.Top, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Top, 1, 10).Active = true;

            NSLayoutConstraint.Create(StatusLabel, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Leading, 1, 30).Active = true;
            NSLayoutConstraint.Create(StatusLabel, NSLayoutAttribute.Top, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Top, 1, 80).Active = true;



            NSLayoutConstraint.Create(ResetBtn, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Leading, 1, 270).Active = true;
            NSLayoutConstraint.Create(ResetBtn, NSLayoutAttribute.Top, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Top, 1, 10).Active = true;


            NSLayoutConstraint.Create(NotStaredLabel, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Leading, 1, 30).Active = true;
            NSLayoutConstraint.Create(NotStaredLabel, NSLayoutAttribute.Top, NSLayoutRelation.Equal, StatusLabel, NSLayoutAttribute.Top, 1, 50).Active = true;

            NSLayoutConstraint.Create(InProgessLabel, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Leading, 1, 30).Active = true;
            NSLayoutConstraint.Create(InProgessLabel, NSLayoutAttribute.Top, NSLayoutRelation.Equal, NotStaredLabel, NSLayoutAttribute.Top, 1, 50).Active = true;

            NSLayoutConstraint.Create(OnHoldLabel, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Leading, 1, 30).Active = true;
            NSLayoutConstraint.Create(OnHoldLabel, NSLayoutAttribute.Top, NSLayoutRelation.Equal, InProgessLabel, NSLayoutAttribute.Top, 1, 50).Active = true;

            NSLayoutConstraint.Create(CompleteLabel, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Leading, 1, 30).Active = true;
            NSLayoutConstraint.Create(CompleteLabel, NSLayoutAttribute.Top, NSLayoutRelation.Equal, OnHoldLabel, NSLayoutAttribute.Top, 1, 50).Active = true;

            NSLayoutConstraint.Create(PriorityLabel, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Leading, 1, 30).Active = true;
            NSLayoutConstraint.Create(PriorityLabel, NSLayoutAttribute.Top, NSLayoutRelation.Equal, CompleteLabel, NSLayoutAttribute.Top, 1, 50).Active = true;

            NSLayoutConstraint.Create(LowLabel, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Leading, 1, 30).Active = true;
            NSLayoutConstraint.Create(LowLabel, NSLayoutAttribute.Top, NSLayoutRelation.Equal, PriorityLabel, NSLayoutAttribute.Top, 1, 50).Active = true;

            NSLayoutConstraint.Create(MediumLabel, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Leading, 1, 30).Active = true;
            NSLayoutConstraint.Create(MediumLabel, NSLayoutAttribute.Top, NSLayoutRelation.Equal, LowLabel, NSLayoutAttribute.Top, 1, 50).Active = true;

            NSLayoutConstraint.Create(HighLabel, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Leading, 1, 30).Active = true;
            NSLayoutConstraint.Create(HighLabel, NSLayoutAttribute.Top, NSLayoutRelation.Equal, MediumLabel, NSLayoutAttribute.Top, 1, 50).Active = true;


            NSLayoutConstraint.Create(NotstartedBtn, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, NotStaredLabel, NSLayoutAttribute.Leading, 1, 240).Active = true;
            NSLayoutConstraint.Create(NotstartedBtn, NSLayoutAttribute.Top, NSLayoutRelation.Equal, StatusLabel, NSLayoutAttribute.Top, 1, 50).Active = true;
            NSLayoutConstraint.Create(NotstartedBtn, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 20).Active = true;
            NSLayoutConstraint.Create(NotstartedBtn, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 20).Active = true;


            NSLayoutConstraint.Create(ProgressBtn, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, NotStaredLabel, NSLayoutAttribute.Leading, 1, 240).Active = true;
            NSLayoutConstraint.Create(ProgressBtn, NSLayoutAttribute.Top, NSLayoutRelation.Equal, NotstartedBtn, NSLayoutAttribute.Top, 1, 50).Active = true;
            NSLayoutConstraint.Create(ProgressBtn, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 20).Active = true;
            NSLayoutConstraint.Create(ProgressBtn, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 20).Active = true;


            NSLayoutConstraint.Create(OnholeBtn, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, NotStaredLabel, NSLayoutAttribute.Leading, 1, 240).Active = true;
            NSLayoutConstraint.Create(OnholeBtn, NSLayoutAttribute.Top, NSLayoutRelation.Equal, ProgressBtn, NSLayoutAttribute.Top, 1, 50).Active = true;
            NSLayoutConstraint.Create(OnholeBtn, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 20).Active = true;
            NSLayoutConstraint.Create(OnholeBtn, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 20).Active = true;


            NSLayoutConstraint.Create(CompleteBtn, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, NotStaredLabel, NSLayoutAttribute.Leading, 1, 240).Active = true;
            NSLayoutConstraint.Create(CompleteBtn, NSLayoutAttribute.Top, NSLayoutRelation.Equal, OnholeBtn, NSLayoutAttribute.Top, 1, 50).Active = true;
            NSLayoutConstraint.Create(CompleteBtn, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 20).Active = true;
            NSLayoutConstraint.Create(CompleteBtn, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 20).Active = true;


            NSLayoutConstraint.Create(LowBtn, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, NotStaredLabel, NSLayoutAttribute.Leading, 1, 240).Active = true;
            NSLayoutConstraint.Create(LowBtn, NSLayoutAttribute.Top, NSLayoutRelation.Equal, PriorityLabel, NSLayoutAttribute.Top, 1, 50).Active = true;
            NSLayoutConstraint.Create(LowBtn, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 20).Active = true;
            NSLayoutConstraint.Create(LowBtn, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 20).Active = true;


            NSLayoutConstraint.Create(MediumBtn, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, NotStaredLabel, NSLayoutAttribute.Leading, 1, 240).Active = true;
            NSLayoutConstraint.Create(MediumBtn, NSLayoutAttribute.Top, NSLayoutRelation.Equal, LowBtn, NSLayoutAttribute.Top, 1, 50).Active = true;
            NSLayoutConstraint.Create(MediumBtn, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 20).Active = true;
            NSLayoutConstraint.Create(MediumBtn, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 20).Active = true;


            NSLayoutConstraint.Create(highBtn, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, NotStaredLabel, NSLayoutAttribute.Leading, 1, 240).Active = true;
            NSLayoutConstraint.Create(highBtn, NSLayoutAttribute.Top, NSLayoutRelation.Equal, MediumBtn, NSLayoutAttribute.Top, 1, 50).Active = true;
            NSLayoutConstraint.Create(highBtn, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 20).Active = true;
            NSLayoutConstraint.Create(highBtn, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 20).Active = true;



            NSLayoutConstraint.Create(FilterBtn, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, notificationpopup, NSLayoutAttribute.Leading, 1, 30).Active = true;
            NSLayoutConstraint.Create(FilterBtn, NSLayoutAttribute.Top, NSLayoutRelation.Equal, highBtn, NSLayoutAttribute.Top, 1, 80).Active = true;
            //NSLayoutConstraint.Create(FilterBtn, NSLayoutAttribute.Height, NSLayoutRelation.Equal, View, NSLayoutAttribute.Height, 1, 40).Active = true;
            //NSLayoutConstraint.Create(FilterBtn, NSLayoutAttribute.Width, NSLayoutRelation.Equal, View, NSLayoutAttribute.Width, 1, 100).Active = true;
            NSLayoutConstraint.Create(FilterBtn, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 270).Active = true;
            NSLayoutConstraint.Create(FilterBtn, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 55).Active = true;

        }
    }
}

