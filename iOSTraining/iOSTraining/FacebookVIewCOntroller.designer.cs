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
    [Register ("FacebookVIewCOntroller")]
    partial class FacebookVIewCOntroller
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel fbid { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView Fcoverpageimage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView myprofileimage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Nameofuser { get; set; }

        [Action ("UIButton481609_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton481609_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (fbid != null) {
                fbid.Dispose ();
                fbid = null;
            }

            if (Fcoverpageimage != null) {
                Fcoverpageimage.Dispose ();
                Fcoverpageimage = null;
            }

            if (myprofileimage != null) {
                myprofileimage.Dispose ();
                myprofileimage = null;
            }

            if (Nameofuser != null) {
                Nameofuser.Dispose ();
                Nameofuser = null;
            }
        }
    }
}