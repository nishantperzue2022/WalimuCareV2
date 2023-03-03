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

            this.BindingContext = new RattingBarViewModal();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = DependencyService.Get<HomePageViewModel>();
            //BindingContext = DependencyService.Get<RattingBarViewModal>();

        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            //return true
        }
    }
}