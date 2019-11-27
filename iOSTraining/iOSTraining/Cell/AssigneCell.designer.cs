// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace iOSTraining.Cell
{
    [Register ("AssigneCell")]
    partial class AssigneCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel assignecodelabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (assignecodelabel != null) {
                assignecodelabel.Dispose ();
                assignecodelabel = null;
            }
        }
    }
}