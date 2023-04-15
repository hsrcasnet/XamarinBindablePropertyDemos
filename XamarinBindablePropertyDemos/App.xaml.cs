using Xamarin.Forms;
using XamarinBindablePropertyDemos.Views;

namespace XamarinBindablePropertyDemos
{
    public partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();

            this.MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
