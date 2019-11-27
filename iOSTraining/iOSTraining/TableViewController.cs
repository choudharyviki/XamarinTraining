using Foundation;
using iOSTraining.Source;
using System;
using UIKit;

namespace iOSTraining
{
    public partial class TableViewController : UIViewController
    {
        public TableViewController(IntPtr handle) : base(handle)
        {
        }
        public TableViewController() : base("ScrollerViewController", null)
        {
        }
        public override void ViewDidLoad()
        {
            MyTable.Source = new TableSource();
        }
    }
}