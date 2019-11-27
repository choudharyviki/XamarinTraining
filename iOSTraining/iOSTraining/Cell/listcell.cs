using System;

using Foundation;
using UIKit;

namespace iOSTraining.Cell
{
    public partial class listcell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("listcell");
        public static readonly UINib Nib;
        public string MyName
        {
            get
            {
                return mynamelable.Text;
            }
            set
            {
                mynamelable.Text = value;
            }
        }
        public string VendorName
        {
            get
            {
                return vendornamelabel.Text;
            }
            set
            {
                vendornamelabel.Text = value;
            }
        }
        static listcell()
        {
            Nib = UINib.FromName("listcell", NSBundle.MainBundle);
        }

        protected listcell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
