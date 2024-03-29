﻿using System;
using WalimuCareApp.Services;
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

            DependencyService.Register<MockDataStore>();

            var accessToken = Preferences.Get("accessToken", string.Empty);

            if (string.IsNullOrEmpty(accessToken))
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                MainPage = new AppShell();

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
    }
}
