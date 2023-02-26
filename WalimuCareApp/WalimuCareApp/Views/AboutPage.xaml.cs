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
		}
		private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			try
			{
				await Navigation.PushAsync(new DependantPage());

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
		{
			try
			{
				await Navigation.PushAsync(new HospitalVisitPage());

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);

				await DisplayAlert("Oops !", "Something went wrong please try again", "Ok");
			}
		}
	}
}