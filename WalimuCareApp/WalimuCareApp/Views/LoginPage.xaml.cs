using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void TapBack_Tapped(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private async void TapLogin_Tapped(object sender, EventArgs e)
        {
            try
            {
                var response = await UserManagerRepository.Login(EntEmail.Text, EntPassword.Text);

                Preferences.Set("email", EntEmail.Text);

                Preferences.Set("password", EntPassword.Text);

                if (response == true)
                {
                    //await Task.Delay(2000);

                    await Application.Current.MainPage.Navigation.PopAsync();

                    Application.Current.MainPage = new AppShell();

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
    }
}