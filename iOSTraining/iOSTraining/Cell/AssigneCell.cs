using System;

using Foundation;
using UIKit;

namespace iOSTraining.Cell
{
    public partial class AssigneCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("AssigneCell");
        public static readonly UINib Nib;

        static AssigneCell()
        {
            Nib = UINib.FromName("AssigneCell", NSBundle.MainBundle);
        }

        protected AssigneCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
