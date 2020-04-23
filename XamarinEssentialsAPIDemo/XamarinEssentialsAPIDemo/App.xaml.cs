using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinEssentialsAPIDemo.Views;

namespace XamarinEssentialsAPIDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DeviceInfoPage();
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
