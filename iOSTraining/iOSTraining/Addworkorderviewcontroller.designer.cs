﻿// WARNING
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
    [Register ("Addworkorderviewcontroller")]
    partial class Addworkorderviewcontroller
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton cancelbutton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Descriptionvalidation { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Faclitytextbox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TitleValidation { get; set; }

        [Action ("UIButton473730_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton473730_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (cancelbutton != null) {
                cancelbutton.Dispose ();
                cancelbutton = null;
            }

            if (Descriptionvalidation != null) {
                Descriptionvalidation.Dispose ();
                Descriptionvalidation = null;
            }

            if (Faclitytextbox != null) {
                Faclitytextbox.Dispose ();
                Faclitytextbox = null;
            }

            if (TitleValidation != null) {
                TitleValidation.Dispose ();
                TitleValidation = null;
            }
        }
    }
}