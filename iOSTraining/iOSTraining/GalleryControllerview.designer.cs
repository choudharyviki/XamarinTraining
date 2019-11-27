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
    [Register ("GalleryControllerview")]
    partial class GalleryControllerview
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView picker { get; set; }

        [Action ("UIButton23281_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton23281_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton23284_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton23284_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton23286_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton23286_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton23288_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton23288_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton23290_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton23290_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (picker != null) {
                picker.Dispose ();
                picker = null;
            }
        }
    }
}