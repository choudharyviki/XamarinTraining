using System;
using iOSTraining.Source;
using UIKit;

namespace iOSTraining
{
    public partial class WorkOrderMainControllerview : UIViewController
    {
        int check = 0;
        public WorkOrderMainControllerview() : base("WorkOrderMainControllerview", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Workorderunderline.Hidden = true;
            Myworktable.Source = new MyWorkOrderSource(check);
            // Perform any additional setup after loading the view, typically from a nib.
        }
        public WorkOrderMainControllerview(IntPtr handle) : base(handle)
        {
        }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton388442_TouchUpInside(UIButton sender)
        {
            check = 0;
            Myworktable.Source = new MyWorkOrderSource(check);
            Myworktable.ReloadData();
            Workorderunderline.Hidden = true;
            Assigneunderline.Hidden = false;
        }

        partial void UIButton388443_TouchUpInside(UIButton sender)
        {
            check = 1;
            Myworktable.Source = new MyWorkOrderSource(check);
            Myworktable.ReloadData();

            Assigneunderline.Hidden = true;
            Workorderunderline.Hidden = false;
        }
    }
}

