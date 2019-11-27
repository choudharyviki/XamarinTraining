using System;

using Foundation;
using UIKit;

namespace iOSTraining.Cell
{
    public partial class MyworkorderCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("MyworkorderCell");
        public static readonly UINib Nib;

        static MyworkorderCell()
        {
            Nib = UINib.FromName("MyworkorderCell", NSBundle.MainBundle);
        }

        protected MyworkorderCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
