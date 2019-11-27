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
    [Register ("secondviewcontroller")]
    partial class secondviewcontroller
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LoginLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton NextBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView SecondScreen { get; set; }

        [Action ("NextBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void NextBtn_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton226350_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton226350_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton259720_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton259720_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton333569_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton333569_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton371944_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton371944_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton434458_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton434458_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton86413_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton86413_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (LoginLabel != null) {
                LoginLabel.Dispose ();
                LoginLabel = null;
            }

            if (NextBtn != null) {
                NextBtn.Dispose ();
                NextBtn = null;
            }

            if (SecondScreen != null) {
                SecondScreen.Dispose ();
                SecondScreen = null;
            }
        }
    }
}