﻿// WARNING
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
    [Register ("listcell")]
    partial class listcell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel mynamelable { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel vendornamelabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (mynamelable != null) {
                mynamelable.Dispose ();
                mynamelable = null;
            }

            if (vendornamelabel != null) {
                vendornamelabel.Dispose ();
                vendornamelabel = null;
            }
        }
    }
}