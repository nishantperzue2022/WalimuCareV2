using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalimuCareApp.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalimuCareApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewBomaCoverBenefitsAndPremiumsPage : CustomContentPageRenderer
    {
        public ViewBomaCoverBenefitsAndPremiumsPage()
        {
            InitializeComponent();

            BindingContext = DependencyService.Get<ViewBomaBenefitCoverAndPremiumsViewModel>();
        }
    }
}