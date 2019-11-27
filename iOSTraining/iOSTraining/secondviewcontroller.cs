using Foundation;
using System;
using UIKit;

namespace iOSTraining
{
    public partial class secondviewcontroller : UIViewController
    {
      public string UserName
        {
            get;
            set;
        }

        public secondviewcontroller (IntPtr handle) : base (handle)
        {
        }
         public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            LoginLabel.Text = "Welcome " + UserName;

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void NextBtn_TouchUpInside(UIButton sender)
        {
           
            try
             {

            var controller = this.Storyboard.InstantiateViewController("welcome") as WelcomeViewController;
                var window = UIApplication.SharedApplication.KeyWindow;
                var nc = window.RootViewController as UINavigationController;
                nc.PushViewController(controller, true);
               
            }
            catch(Exception e)
           {

            }
        }

        partial void UIButton86413_TouchUpInside(UIButton sender)
        {
            var controller = this.Storyboard.InstantiateViewController("hallcon") as scrollviewtestviewconrtoller;
            var window = UIApplication.SharedApplication.KeyWindow;
            var nc = window.RootViewController as UINavigationController;
            nc.PushViewController(controller, true);

        }

        partial void UIButton226350_TouchUpInside(UIButton sender)
        {
            PerformSegue("LoginScreenSegue", this);
            
        }

        partial void UIButton259720_TouchUpInside(UIButton sender)
        {
            PerformSegue("Directorylistsegue", this); 
        }

        partial void UIButton333569_TouchUpInside(UIButton sender)
        {
            PerformSegue("workphotosegue", this);
            
        }

        partial void UIButton371944_TouchUpInside(UIButton sender)
        {
            PerformSegue("Workordermainsegue", this); 
        }

        partial void UIButton434458_TouchUpInside(UIButton sender)
        {
            PerformSegue("Addwrokordersegue", this);
           
        }
    }
}