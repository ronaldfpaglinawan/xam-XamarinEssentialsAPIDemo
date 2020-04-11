using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentialsAPIDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppThemePage : ContentPage
    {
        public AppThemePage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // For checking the current app theme
            AppTheme appTheme = AppInfo.RequestedTheme;
            DisplayAlert("Theme", $"The current app theme is {appTheme} theme", "OK");
        }
    }
}