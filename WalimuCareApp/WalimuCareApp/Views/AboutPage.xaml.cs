using System;
using System.ComponentModel;
using WalimuCareApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalimuCareApp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
		protected override void OnAppearing()
		{
			base.OnAppearing();

			BindingContext = DependencyService.Get<HomePageViewModel>();

		}
	}
}