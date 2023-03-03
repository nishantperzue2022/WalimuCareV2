using System;
using System.Diagnostics;
using WalimuCareApp.Services;
using WalimuCareApp.Utils;
using WalimuCareApp.ViewModels;
using WalimuCareApp.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WalimuCareApp
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTI0Nzg0MkAzMjMwMmUzNDJlMzBHZS9Cdnl2ZHRKY3dZTmtIQnlJNDEzamJiK21nakxBbXRrUnFZd1p1ZHFjPQ==\r\n");

            XF.Material.Forms.Material.Init(this);

            SetApiDetails();

            RegisterDependencyModels();

            var accessToken = Preferences.Get("accessToken", string.Empty);

            var memberNo = Preferences.Get("memberName", string.Empty);

            //  MainPage = new NavigationPage(new BlogArticles());

            if (string.IsNullOrEmpty(memberNo))
            {
                MainPage = new NavigationPage(new WelcomeScreenPage());
            }
            else
            {
                MainPage = new LoginPage();

            }
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

            DependencyService.Register<WellnessBlogViewModel>();

            DependencyService.Register<PolicyLimitsViewModel>();

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
