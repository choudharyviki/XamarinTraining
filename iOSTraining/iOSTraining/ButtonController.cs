

using System;
using System.Collections.Generic;
using UIKit;

namespace iOSTraining
{
    public partial class ButtonController : UIViewController
    {
        UIButton btn;
        NSLayoutConstraint nextBtnConstraint;
        int topConstrain = 100;
        int btnCount = 1;
        int noOfRemove = 0;
        int index = 0;
        UIButton previousbtn,nextbtn1;
        List<UIButton> buttonContainerList = new List<UIButton>();
        NSLayoutConstraint[] constraint; //= new NSLayoutConstraint[10];
        public ButtonController() : base("ButtonController", null)
        {
        }
        public ButtonController(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            btn = new UIButton();
            previousbtn = btn;
           // nextbtn1 = btn;
            btn.TranslatesAutoresizingMaskIntoConstraints = false;
            btn.SetTitle("Button1", UIControlState.Normal);
            btn.BackgroundColor = UIColor.Red;
            View.Add(btn);
            NSLayoutConstraint.Create(btn, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, View, NSLayoutAttribute.Leading, 1.0f, 30).Active = true;
            NSLayoutConstraint.Create(btn, NSLayoutAttribute.Top, NSLayoutRelation.Equal, View, NSLayoutAttribute.Top, 1.0f, topConstrain).Active = true;
            NSLayoutConstraint.Create(btn, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 40).Active = true;
            NSLayoutConstraint.Create(btn, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 90).Active = true;

            previousbtn = btn;
            btn.TouchUpInside += new EventHandler(ButtonCLick);
            buttonContainerList.Add(btn);

        }

        private void ButtonCLick(object sender, EventArgs e)
        {

           previousbtn.TouchUpInside -= new EventHandler(ButtonCLick);
            previousbtn.TouchUpInside += new EventHandler(RemoveButton);
          // NewButtonAdd();
            RandomButtonAdd(true);

        }

        private void RemoveButton(object sender, EventArgs e)
        {
            noOfRemove++;
            btnCount = 0;
            topConstrain = 40;
            
            UIButton bb = sender as UIButton;

            for (int i=0;i< buttonContainerList.Count;i++)
            {
                if(buttonContainerList[i].TitleLabel.Text==bb.TitleLabel.Text)
                {
                    buttonContainerList.RemoveAt(i);

                }
                    buttonContainerList[i].RemoveFromSuperview();
            }
                  previousbtn.TouchUpInside -= new EventHandler(ButtonCLick);
                 // previousbtn.TouchUpInside += new EventHandler(RemoveButton);

                RandomButtonAdd(false);

            bb.RemoveFromSuperview();
        }

        private void RandomButtonAdd(bool removeButtonNotClick)
        {
            if (removeButtonNotClick)
            {

                if (btnCount % 2 != 0)
                {
                    btnCount++;
                    // topConstrain += 60;
                    nextbtn1 = new UIButton();
                    previousbtn = nextbtn1;
                    nextbtn1.TouchUpInside += new EventHandler(ButtonCLick);
                    nextbtn1.TranslatesAutoresizingMaskIntoConstraints = false;
                    nextbtn1.SetTitle("Button" + btnCount, UIControlState.Normal);
                    nextbtn1.BackgroundColor = UIColor.Red;
                    View.Add(nextbtn1);
                    buttonContainerList.Add(nextbtn1);
                    NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, View, NSLayoutAttribute.Leading, 1.0f, 200).Active = true;
                    NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Top, NSLayoutRelation.Equal, View, NSLayoutAttribute.Top, 1.0f, topConstrain).Active = true;
                    NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 40).Active = true;
                    NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 90).Active = true;
                }
                else
                {
                    
                    
                    btnCount++;
                    topConstrain += 60;
                    nextbtn1 = new UIButton();
                    previousbtn = nextbtn1;
                    nextbtn1.TouchUpInside += new EventHandler(ButtonCLick);
                    nextbtn1.TranslatesAutoresizingMaskIntoConstraints = false;
                    nextbtn1.SetTitle("Button" + btnCount, UIControlState.Normal);
                    nextbtn1.BackgroundColor = UIColor.Red;
                    View.Add(nextbtn1);
                    buttonContainerList.Add(nextbtn1);
                    NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, View, NSLayoutAttribute.Leading, 1.0f, 30).Active = true;
                    NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Top, NSLayoutRelation.Equal, View, NSLayoutAttribute.Top, 1.0f, topConstrain).Active = true;
                    NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 40).Active = true;
                    NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 90).Active = true;
                }

            }
            else
            {
                for (int i = 0; i < buttonContainerList.Count; i++)
                {
                  previousbtn.TouchUpInside -= new EventHandler(ButtonCLick);
                  // previousbtn.TouchUpInside += new EventHandler(RemoveButton);


                    if (btnCount % 2 != 0)
                    {
                        btnCount++;
                        // topConstrain += 60;
                        nextbtn1 = buttonContainerList[i];
                        previousbtn = buttonContainerList[i];
                        nextbtn1.TouchUpInside += new EventHandler(ButtonCLick);
                        nextbtn1.TranslatesAutoresizingMaskIntoConstraints = false;
                        nextbtn1.BackgroundColor = UIColor.Red;
                        View.Add(nextbtn1);
                        NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, View, NSLayoutAttribute.Leading, 1.0f, 200).Active = true;
                        NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Top, NSLayoutRelation.Equal, View, NSLayoutAttribute.Top, 1.0f, topConstrain).Active = true;
                        NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 40).Active = true;
                        NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 90).Active = true;
                    }
                    else
                    {
                        btnCount++;
                        topConstrain += 60;
                        nextbtn1 = buttonContainerList[i];
                        previousbtn = nextbtn1;
                        nextbtn1.TouchUpInside += new EventHandler(ButtonCLick);
                        nextbtn1.TranslatesAutoresizingMaskIntoConstraints = false;
                        nextbtn1.BackgroundColor = UIColor.Red;
                        View.Add(nextbtn1);
                        NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, View, NSLayoutAttribute.Leading, 1.0f, 30).Active = true;
                        NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Top, NSLayoutRelation.Equal, View, NSLayoutAttribute.Top, 1.0f, topConstrain).Active = true;
                        NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 40).Active = true;
                        NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 90).Active = true;
                    }
                }

            }
        }

        private void NewButtonAdd()
        {
            topConstrain += 60;
            nextbtn1 = new UIButton();
            previousbtn = nextbtn1;
            nextbtn1.TouchUpInside += new EventHandler(ButtonCLick);
            nextbtn1.TranslatesAutoresizingMaskIntoConstraints = false;
            nextbtn1.SetTitle("Button2", UIControlState.Normal);
            nextbtn1.BackgroundColor = UIColor.Red;
            View.Add(nextbtn1);
            NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, View, NSLayoutAttribute.Leading, 1.0f, 30).Active = true;
            NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Top, NSLayoutRelation.Equal, View, NSLayoutAttribute.Top, 1.0f, topConstrain).Active = true;
            NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 40).Active = true;
            NSLayoutConstraint.Create(nextbtn1, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 90).Active = true;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

