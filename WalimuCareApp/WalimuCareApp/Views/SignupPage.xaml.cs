using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WalimuCareApp.Models;
using WalimuCareApp.Repositories.UserManagerModule;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalimuCareApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();
        }
        private async void TapSignup_Tapped(object sender, EventArgs e)
        {
            var response = await UserManagerRepository.RegisterUser(txtMemberNo.Text, txtFirstName.Text,txtLastName.Text,txtEmail.Text,txtPassword.Text);

            if (response)
            {
                await DisplayAlert("", "Your account has been created", "Ok");

                await Navigation.PushModalAsync(new LoginPage());
            }
            else
            {
                await DisplayAlert("Oops!", "Something went wrong", "Cancel");

            }
        }

        private async void SpanSignin_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginPage());
        }
    }
}