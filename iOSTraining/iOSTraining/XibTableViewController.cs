using Foundation;
using iOSTraining.Source;
using System;
using UIKit;

namespace iOSTraining
{
    public partial class XibTableViewController : UITableViewController
    {
        public XibTableViewController (IntPtr handle) : base (handle)
        {

        }
        public override void ViewDidLoad()
        {
            XibMyTable.Source = new MyTableviewSource();
        }
    }
}