using Plugin.Toast;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalimuCareApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalimuCareApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppErrorPage : PopupPage
    {
        public string MessageText { get; set; } = "Invalid Member Id or Phone Number";
        public AppErrorPage(string messageText)
        {
            InitializeComponent();

            if (messageText != null || messageText != "")
            {
                MessageText = messageText;
            }
        }

        protected override void OnAppearing()
        {
            lblMessage.Text = MessageText;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                await DependencyService.Get<AppViewModel>().RemoveLoadingMessage();
            }
            catch (Exception ex)
            {
                DependencyService.Get<AppViewModel>().SendErrorMessageToAppCenter(ex, "Error Page");
            }
        }
    }
}