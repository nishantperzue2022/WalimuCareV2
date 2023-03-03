using System;
using System.Diagnostics;
using WalimuCareApp.Services;
using WalimuCareApp.Utils;
using WalimuCareApp.ViewModels;
using WalimuCareApp.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalimuCareApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            XF.Material.Forms.Material.Init(this);

            SetApiDetails();

            RegisterDependencyModels();      

            var accessToken = Preferences.Get("accessToken", string.Empty);

            MainPage = new NavigationPage(new WelcomeScreenPage());

            //if (string.IsNullOrEmpty(accessToken))
            //{
            //    MainPage = new NavigationPage(new LoginPage());
            //}
            //else
            //{
            //    MainPage = new AppShell();

            //}
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
        public void RegisterDependencyModels()
        {

            DependencyService.Register<FaqsViewModel>();

            DependencyService.Register<Covid19ViewModel>();

            DependencyService.Register<MockDataStore>();
        }

        public void SetApiDetails()
        {
            if (Debugger.IsAttached)
            {
                ApiDetail.EndPoint = ApiDetail.LocalEndPoint;
            }
            else
            {
                //means we are on production
                ApiDetail.EndPoint = ApiDetail.PublicEndPoint;
                //ApiDetail.EndPoint = ApiDetail.LocalEndPoint;
            }
        }
    }
}
