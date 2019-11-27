using System;
using CoreGraphics;
using iOSTraining.Model;
using UIKit;

namespace iOSTraining
{
    public partial class GalleryControllerview : UIViewController
    {
        public GalleryControllerview() : base("GalleryControllerview", null)
        {
        }
        public GalleryControllerview(IntPtr handle) : base(handle)
        {
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();



            UIPickerView pickerName = new UIPickerView(new CGRect(UIScreen.MainScreen.Bounds.X - UIScreen.MainScreen.Bounds.Width,
                UIScreen.MainScreen.Bounds.Height - 230, UIScreen.MainScreen.Bounds.Width, 180));
            var searchBar = new UISearchBar();
           // View.AddSubview(pickerName);

            searchBar.Placeholder = "Enter your search item...";
            NavigationItem.TitleView = searchBar;
            var personModel = new PeopleModel();
            picker.Model = personModel;
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton23281_TouchUpInside(UIButton sender)
        {
            var okAlertController = UIAlertController.Create("Message", "Please select option", UIAlertControllerStyle.Alert);
            okAlertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
            okAlertController.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, null));
            PresentViewController(okAlertController, true, null);

        }

        partial void UIButton23284_TouchUpInside(UIButton sender)
        {
            PerformSegue("ButtonGallery", this);
        }

        partial void UIButton23286_TouchUpInside(UIButton sender)
        {
            PerformSegue("testIdentifier", this);
        }

        partial void UIButton23288_TouchUpInside(UIButton sender)
        {
            PerformSegue("TableViewSegue", this);
            
        }

        partial void UIButton23290_TouchUpInside(UIButton sender)
        {
            PerformSegue("XibSegue", this);
        }



        //partial void ScrollviewClicked(UIButton sender)
        //{
        //}

        //public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        //{
        //    base.PrepareForSegue(segue, sender);



        //    if (segue.Identifier.Equals("LoginScreenSuccess"))
        //    {

        //        var callsecondcontroller = (secondviewcontroller)segue.DestinationViewController;
        //        callsecondcontroller.UserName = NameText.Text;
        //    }





        //}
    }
}

