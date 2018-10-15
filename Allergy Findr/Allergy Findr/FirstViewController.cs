using System;
using UIKit;
using ZXing.Mobile;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Allergy_Findr
{
    public partial class FirstViewController : UIViewController
    {
        public FirstViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            b_Scan.TouchUpInside += ScanButtonClicked;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        async void ScanButtonClicked(object sender, EventArgs e)
        {
            MobileBarcodeScanner scanner = new MobileBarcodeScanner();
            var result = await scanner.Scan();

            if (result != null)
            {
                FindIngredients(result.Text);
            }
        }

        async void FindIngredients(string barcode)
        {
            var client = new HttpClient();

            string url = "https://api.nutritionix.com/v1_1/item?upc=" + barcode + "&appId=1f0ccdae&appKey=45d4c13363d317c3e6a7c0a202dea06c";
            string json = await client.GetStringAsync(url);
            RootObject d = JObject.Parse(json).ToObject<RootObject>();
            DisplayIngredients(d.nf_ingredient_statement);
        }

        void DisplayIngredients(string content)
        {
            UIAlertView alert = new UIAlertView()
            {
                Title = "Ingredients Found",
                Message = content
            };
            alert.AddButton("OK");
            alert.Show();
        }

    }
}