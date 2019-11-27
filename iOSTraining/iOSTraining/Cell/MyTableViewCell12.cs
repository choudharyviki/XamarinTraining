using System;

using Foundation;
using UIKit;

namespace iOSTraining.Cell
{
    public partial class MyTableViewCell12 : UITableViewCell
    {
        public static readonly NSString Key = new NSString("MyTableViewCell12");
        public static readonly UINib Nib;

        static MyTableViewCell12()
        {
            Nib = UINib.FromName("MyTableViewCell12", NSBundle.MainBundle);
        }

        protected MyTableViewCell12(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
