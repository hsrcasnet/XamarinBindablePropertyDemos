using Xamarin.Forms;

namespace XamarinBindablePropertyDemos.ViewModels
{
    public class MainViewModel : BindableObject
    {
        public MainViewModel()
        {
            this.ShippingAddress = new AddressViewModel
            {
                Street = "Alpenblick",
                BuildingNo = "7",
                PostCode = "6330",
                Town = "Cham",
            };

            this.BillingAddress = new AddressViewModel
            {
                Street = "Hochschulstrasse",
                BuildingNo = "7a",
                PostCode = "9000",
                Town = "Rapperswil",
            };
        }


        public AddressViewModel ShippingAddress { get; set; }

        public AddressViewModel BillingAddress { get; set; }
    }
}