using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;

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

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PopPopupAsync(true);
        }
    }
}