using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinBindablePropertyDemos.Controls
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddressView : ContentView
    {
        public AddressView()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty StreetProperty =
            BindableProperty.Create(
                nameof(Street),
                typeof(string),
                typeof(AddressView),
                null,
                BindingMode.TwoWay);

        public string Street
        {
            get => (string)this.GetValue(StreetProperty);
            set => this.SetValue(StreetProperty, value);
        }
        
        public static readonly BindableProperty BuildingNoProperty =
            BindableProperty.Create(
                nameof(BuildingNo),
                typeof(string),
                typeof(AddressView),
                null,
                BindingMode.TwoWay);

        public string BuildingNo
        {
            get => (string)this.GetValue(BuildingNoProperty);
            set => this.SetValue(BuildingNoProperty, value);
        }
        
        
        public static readonly BindableProperty PostCodeProperty =
            BindableProperty.Create(
                nameof(PostCode),
                typeof(string),
                typeof(AddressView),
                null,
                BindingMode.TwoWay);

        public string PostCode
        {
            get => (string)this.GetValue(PostCodeProperty);
            set => this.SetValue(PostCodeProperty, value);
        }
        
        public static readonly BindableProperty TownProperty =
            BindableProperty.Create(
                nameof(Town),
                typeof(string),
                typeof(AddressView),
                null,
                BindingMode.TwoWay);

        public string Town
        {
            get => (string)this.GetValue(TownProperty);
            set => this.SetValue(TownProperty, value);
        }
    }
}