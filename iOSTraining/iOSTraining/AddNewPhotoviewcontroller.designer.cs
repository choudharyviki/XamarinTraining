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
    [Register ("AddNewPhotoviewcontroller")]
    partial class AddNewPhotoviewcontroller
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton addphotobtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView addphotoview { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton editbtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton HightBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton NotstartedBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView referigerterview { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton sendmailbtn { get; set; }

        [Action ("Addphotobtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Addphotobtn_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (addphotobtn != null) {
                addphotobtn.Dispose ();
                addphotobtn = null;
            }

            if (addphotoview != null) {
                addphotoview.Dispose ();
                addphotoview = null;
            }

            if (editbtn != null) {
                editbtn.Dispose ();
                editbtn = null;
            }

            if (HightBtn != null) {
                HightBtn.Dispose ();
                HightBtn = null;
            }

            if (NotstartedBtn != null) {
                NotstartedBtn.Dispose ();
                NotstartedBtn = null;
            }

            if (referigerterview != null) {
                referigerterview.Dispose ();
                referigerterview = null;
            }

            if (sendmailbtn != null) {
                sendmailbtn.Dispose ();
                sendmailbtn = null;
            }
        }
    }
}