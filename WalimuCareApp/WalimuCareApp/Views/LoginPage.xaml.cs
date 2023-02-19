using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalimuCareApp.Models;
using WalimuCareApp.Repositories.UserManagerModule;
using WalimuCareApp.Utils;
using WalimuCareApp.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalimuCareApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            this.BindingContext = new LoginViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                var response = await UserManagerRepository.Login(txtMemberNo.Text, txtPassword.Text);                          

                if (response == true)
                {
                    //await Task.Delay(2000);

                    //await Application.Current.MainPage.Navigation.PopAsync();

                    Application.Current.MainPage = new MessageBoxPage();

                }
                else
                {
                    await DisplayAlert("Oops !", "Something went wrong", "Cancel");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                await DisplayAlert("Oops !", "Something went wrong", "Cancel");

            }



        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignupPage());
        }



        //private async void TapLogin_Tapped(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //var response = await UserManagerRepository.Login(txtMemberNo.Text, EntPassword.Text);

        //        //Preferences.Set("email", txtMemberNo.Text);

        //        //Preferences.Set("password", EntPassword.Text);

        //        //if (response == true)
        //        //{
        //        //    //await Task.Delay(2000);

        //        //    await Application.Current.MainPage.Navigation.PopAsync();

        //        //    Application.Current.MainPage = new AppShell();

        //        //}
        //        //else
        //        //{
        //        //    await DisplayAlert("Oops !", "Something went wrong", "Cancel");
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);

        //        await DisplayAlert("Oops !", "Something went wrong", "Cancel");

        //    }
        //}


    }
}