using Xamarin.Forms;
using XamarinBindablePropertyDemos.ViewModels;

namespace XamarinBindablePropertyDemos.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.BindingContext = new MainViewModel();
        }
    }
}
