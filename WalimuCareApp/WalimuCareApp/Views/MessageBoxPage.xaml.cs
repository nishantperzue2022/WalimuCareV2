using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalimuCareApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessageBoxPage : PopupPage
    {
        public MessageBoxPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Task.Delay(2000);

            //await Application.Current.MainPage.Navigation.PopAsync();

            Application.Current.MainPage = new AppShell();
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    App.Current.MainPage.Navigation.PopPopupAsync(true);
        //}


    }
}