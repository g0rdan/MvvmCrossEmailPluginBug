// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TestMvvmCrossEmailPlugin.iOS.Views
{
    [Register ("FirstView")]
    partial class FirstView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton EmailButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (EmailButton != null) {
                EmailButton.Dispose ();
                EmailButton = null;
            }
        }
    }
}