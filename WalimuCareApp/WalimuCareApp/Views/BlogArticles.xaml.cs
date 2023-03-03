using WalimuCareApp.CustomRenderer;
using WalimuCareApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalimuCareApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BlogArticles : CustomContentPageRenderer
    {
        public BlogArticles()
        {
            InitializeComponent();

            BindingContext = DependencyService.Get<WellnessBlogViewModel>();
        }
    }
}