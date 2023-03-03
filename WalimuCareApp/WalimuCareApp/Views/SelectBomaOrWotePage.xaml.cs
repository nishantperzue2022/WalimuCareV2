using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalimuCareApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectBomaOrWotePage : ContentPage
    {
        public SelectBomaOrWotePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = DependencyService.Get<SelectBomaOrWotePageViewModel>();
        }
    }
}