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

            RegisterMyRoutes();
        }

        private void OnMenuItemClicked(object sender, EventArgs e)
        {
            Preferences.Set("accessToken", string.Empty);

            Preferences.Set("tokenExpirationTime", 0);

            Application.Current.MainPage = new NavigationPage();

            Application.Current.MainPage = new NavigationPage(new LoginPage());

            /// await Shell.Current.GoToAsync("//SignupPage");
        }

        public void RegisterMyRoutes()
        {
            try
            {
                Routing.RegisterRoute(nameof(Covid19Page), typeof(Covid19Page));

                Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));

                Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));

                Routing.RegisterRoute(nameof(DependantPage), typeof(DependantPage));

                Routing.RegisterRoute(nameof(FindHospitalPage), typeof(FindHospitalPage));

                Routing.RegisterRoute(nameof(TelemedicinePage), typeof(TelemedicinePage));

                Routing.RegisterRoute(nameof(HospitalVisitPage), typeof(HospitalVisitPage));

                Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));

                Routing.RegisterRoute(nameof(FindHospitalPage), typeof(FindHospitalPage));

                Routing.RegisterRoute(nameof(ContactUsPage), typeof(ContactUsPage));

                Routing.RegisterRoute(nameof(PolicyLimitsPage), typeof(PolicyLimitsPage));

                Routing.RegisterRoute(nameof(PolicyDetailsPage), typeof(PolicyDetailsPage));

                Routing.RegisterRoute(nameof(BlogArticles), typeof(BlogArticles));

                Routing.RegisterRoute(nameof(MedicalCoverOrdersPage), typeof(MedicalCoverOrdersPage));

                Routing.RegisterRoute(nameof(SubmitComplaintsPage), typeof(SubmitComplaintsPage));

                Routing.RegisterRoute(nameof(ComplaintsPage), typeof(ComplaintsPage));

                Routing.RegisterRoute(nameof(CallBacksPage), typeof(CallBacksPage));

                Routing.RegisterRoute(nameof(FAQPage), typeof(FAQPage));

                Routing.RegisterRoute(nameof(ECardPage), typeof(ECardPage));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
