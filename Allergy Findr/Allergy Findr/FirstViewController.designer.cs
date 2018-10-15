// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Allergy_Findr
{
    [Register ("FirstViewController")]
    partial class FirstViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton b_Scan { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel l_FoodName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView t_Ingredients { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (b_Scan != null) {
                b_Scan.Dispose ();
                b_Scan = null;
            }

            if (l_FoodName != null) {
                l_FoodName.Dispose ();
                l_FoodName = null;
            }

            if (t_Ingredients != null) {
                t_Ingredients.Dispose ();
                t_Ingredients = null;
            }
        }
    }
}