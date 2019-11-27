using Foundation;
using System;
using UIKit;

namespace iOSTraining
{
    public partial class EMployeecell : UITableViewCell
    {
        public EMployeecell (IntPtr handle) : base (handle)
        {
        }

        internal void SetEMployeeData(Employee employee)
        {
            EmpNameLabel.Text = employee.EmployeeName;
            WorkLable.Text = employee.EmployeeVendor;

            myview.Layer.CornerRadius = 5;
            myview.Layer.ShadowColor = UIColor.LightGray.CGColor;
            myview.Layer.ShadowOpacity = 1.0f;
            myview.Layer.ShadowRadius = 5.0f;
            myview.Layer.ShadowOffset = new System.Drawing.SizeF(5f, 5f);
            myview.BackgroundColor = UIColor.White;

            UserImage.Layer.CornerRadius = 48;
            UserImage.Layer.MasksToBounds = true;

        }

    }
}