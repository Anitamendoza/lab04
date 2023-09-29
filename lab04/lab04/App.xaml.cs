using lab04.Services;
using lab04.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab04
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            //Main Page = navegation( new Page2());
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
