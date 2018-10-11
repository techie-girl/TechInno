using System;
using UIKit;
using ZXing.Mobile;

namespace Allergy_Findr
{
    public partial class FirstViewController : UIViewController
    {

        public FirstViewController (IntPtr handle) : base (handle)
        {

        }
        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();


            b_Scan.TouchUpInside += ScanButtonClicked;
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }

        async void ScanButtonClicked(object sender, EventArgs e)
        {
            MobileBarcodeScanner scanner = new MobileBarcodeScanner();
            var result = await scanner.Scan();

            if (result != null)
            {
                l_BarcodeNumber.Text = result.Text;
            }
        }

    }
}