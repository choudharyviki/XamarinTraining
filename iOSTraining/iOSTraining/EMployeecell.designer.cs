// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iOSTraining
{
    [Register ("EMployeecell")]
    partial class EMployeecell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel EmpNameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView myview { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView UserImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel WorkLable { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (EmpNameLabel != null) {
                EmpNameLabel.Dispose ();
                EmpNameLabel = null;
            }

            if (myview != null) {
                myview.Dispose ();
                myview = null;
            }

            if (UserImage != null) {
                UserImage.Dispose ();
                UserImage = null;
            }

            if (WorkLable != null) {
                WorkLable.Dispose ();
                WorkLable = null;
            }
        }
    }
}