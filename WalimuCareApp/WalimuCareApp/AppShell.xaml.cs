using System;
using System.Collections.Generic;
using WalimuCareApp.ViewModels;
using WalimuCareApp.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WalimuCareApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));

            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));

            Routing.RegisterRoute(nameof(DependantPage), typeof(DependantPage));

            Routing.RegisterRoute(nameof(FindHospitalPage), typeof(FindHospitalPage));
        }

        private void OnMenuItemClicked(object sender, EventArgs e)
        {
            Preferences.Set("accessToken", string.Empty);

            Preferences.Set("tokenExpirationTime", 0);

            Application.Current.MainPage = new NavigationPage();

            Application.Current.MainPage = new NavigationPage(new LoginPage());

            /// await Shell.Current.GoToAsync("//SignupPage");
        }
    }
}
