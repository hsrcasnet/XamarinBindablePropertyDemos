using Xamarin.Forms;
using XamarinBindablePropertyDemos.ViewModels;

namespace XamarinBindablePropertyDemos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
