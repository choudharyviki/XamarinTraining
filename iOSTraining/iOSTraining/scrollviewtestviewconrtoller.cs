using System;
using System.Collections.Generic;
using UIKit;

namespace iOSTraining
{
    public partial class scrollviewtestviewconrtoller : UIViewController
    {
        int topconstant = 20;
        int count = 1;
        UIScrollView scrollView;
        UIView view;
        int counter;
        // UIButton btn;
        int topLineConstraint = 0;
        int topCircleConstraint = 0;
        int viewTopConstraint = 0;
        UIView previousView, nextView;

        List<UIView> btnContainer = new List<UIView>();
        public bool DeleteView { get; private set; }

        public scrollviewtestviewconrtoller() : base("scrollviewtestviewconrtoller", null)
        {
        }
        public scrollviewtestviewconrtoller(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationItem.HidesBackButton = true;
            circle.Layer.BorderWidth = 3;
            circle.Layer.BorderColor = UIColor.Red.CGColor;
            scrollView = new UIScrollView();
            scrollView.TranslatesAutoresizingMaskIntoConstraints = false;
            scrollView.ContentSize = new CoreGraphics.CGSize(600, 2000);
            View.Add(scrollView);
           
            NSLayoutConstraint.Create(scrollView, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, View, NSLayoutAttribute.Leading, 1.0f, 50).Active = true;
            NSLayoutConstraint.Create(scrollView, NSLayoutAttribute.Top, NSLayoutRelation.Equal, circle, NSLayoutAttribute.Top, 1.0f, 120).Active = true;
            NSLayoutConstraint.Create(scrollView, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 413).Active = true;
            NSLayoutConstraint.Create(scrollView, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 600).Active = true;

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        partial void UIButton127518_TouchUpInside(UIButton sender)
        {
            CreateNewView();
        }
        public void CreateNewView()
        {
            counter++;
           
            var tempview = new UIButton();
            var btn = new UIButton();

            var timeLabel = new UILabel();
            timeLabel.Text = "8:10";
            var arriveLabel = new UILabel();
            arriveLabel.Text = "Arrive";
            var deleteBtn = new UIButton();
            deleteBtn.SetImage(UIImage.FromFile("delete.png"), UIControlState.Normal);
            timeLabel.TranslatesAutoresizingMaskIntoConstraints = false;
            arriveLabel.TranslatesAutoresizingMaskIntoConstraints = false;
            deleteBtn.TranslatesAutoresizingMaskIntoConstraints = false;

            deleteBtn.AddTarget(DepartButtonClick, UIControlEvent.TouchUpInside);
            tempview.BackgroundColor = UIColor.Black;
            tempview.TranslatesAutoresizingMaskIntoConstraints = false;

            btn.TranslatesAutoresizingMaskIntoConstraints = false;
            btn.BackgroundColor = UIColor.Green;
            btn.Layer.CornerRadius = 21;
            view = new UIView();
            view.Add(btn);
            view.Add(tempview);
            view.Add(arriveLabel);
            view.Add(timeLabel);
            view.Add(deleteBtn);
            view.TranslatesAutoresizingMaskIntoConstraints = false;

            scrollView.ContentSize = new CoreGraphics.CGSize(600, viewTopConstraint+80);

            scrollView.Add(view);
            btnContainer.Add(view);
            NSLayoutConstraint.Create(view, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, scrollView, NSLayoutAttribute.Leading, 1.0f, 0).Active = true;
            NSLayoutConstraint.Create(view, NSLayoutAttribute.Top, NSLayoutRelation.Equal, scrollView, NSLayoutAttribute.Top, 1.0f, viewTopConstraint).Active = true;
            NSLayoutConstraint.Create(view, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 100).Active = true;
            NSLayoutConstraint.Create(view, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 300).Active = true;

            NSLayoutConstraint.Create(timeLabel, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, view, NSLayoutAttribute.Leading, 1.0f, 50).Active = true;
            NSLayoutConstraint.Create(timeLabel, NSLayoutAttribute.Top, NSLayoutRelation.Equal, view, NSLayoutAttribute.Top, 1.0f, 50).Active = true;
            NSLayoutConstraint.Create(timeLabel, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 30).Active = true;
            NSLayoutConstraint.Create(timeLabel, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 100).Active = true;

            NSLayoutConstraint.Create(arriveLabel, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, view, NSLayoutAttribute.Leading, 1.0f, 180).Active = true;
            NSLayoutConstraint.Create(arriveLabel, NSLayoutAttribute.Top, NSLayoutRelation.Equal, view, NSLayoutAttribute.Top, 1.0f, 50).Active = true;
            NSLayoutConstraint.Create(arriveLabel, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 30).Active = true;
            NSLayoutConstraint.Create(arriveLabel, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 100).Active = true;

            NSLayoutConstraint.Create(deleteBtn, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, view, NSLayoutAttribute.Leading, 1.0f, 230).Active = true;
            NSLayoutConstraint.Create(deleteBtn, NSLayoutAttribute.Top, NSLayoutRelation.Equal, view, NSLayoutAttribute.Top, 1.0f, 53).Active = true;
           // NSLayoutConstraint.Create(deleteBtn, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 30).Active = true;
           // NSLayoutConstraint.Create(deleteBtn, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 100).Active = true;


            NSLayoutConstraint.Create(btn, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, view, NSLayoutAttribute.Leading, 1.0f, 130).Active = true;
            NSLayoutConstraint.Create(btn, NSLayoutAttribute.Top, NSLayoutRelation.Equal, view, NSLayoutAttribute.Top, 1.0f, 50).Active = true;
            NSLayoutConstraint.Create(btn, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 40).Active = true;
            NSLayoutConstraint.Create(btn, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 40).Active = true;

            NSLayoutConstraint.Create(tempview, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, view, NSLayoutAttribute.Leading, 1.0f, 150).Active = true;
            NSLayoutConstraint.Create(tempview, NSLayoutAttribute.Top, NSLayoutRelation.Equal, view, NSLayoutAttribute.Top, 1.0f, 3).Active = true;
            NSLayoutConstraint.Create(tempview, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 50).Active = true;
            NSLayoutConstraint.Create(tempview, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 3).Active = true;
            viewTopConstraint += 90;
            if(counter>1)
            {
                for(int i=0;i<btnContainer.Count-1;i++)

                {
                    btnContainer[i].Subviews[4].Hidden=true;
                }
            }
        }

        private void DepartButtonClick(object sender, EventArgs e)
        {

            if (counter > 1)
            {
                btnContainer[btnContainer.Count - 1].RemoveFromSuperview();
                btnContainer.RemoveAt(btnContainer.Count - 1);
                btnContainer[btnContainer.Count - 1].Subviews[4].Hidden = false;
            }
            else if (counter == 1)
                btnContainer[0].RemoveFromSuperview();

            counter--;
            viewTopConstraint -= 90;
        }
    }
}

