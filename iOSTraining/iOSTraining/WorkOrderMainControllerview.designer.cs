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
    [Register ("WorkOrderMainControllerview")]
    partial class WorkOrderMainControllerview
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Assigneunderline { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView Myworktable { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Workorderunderline { get; set; }

        [Action ("UIButton388442_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton388442_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton388443_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton388443_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (Assigneunderline != null) {
                Assigneunderline.Dispose ();
                Assigneunderline = null;
            }

            if (Myworktable != null) {
                Myworktable.Dispose ();
                Myworktable = null;
            }

            if (Workorderunderline != null) {
                Workorderunderline.Dispose ();
                Workorderunderline = null;
            }
        }
    }
}