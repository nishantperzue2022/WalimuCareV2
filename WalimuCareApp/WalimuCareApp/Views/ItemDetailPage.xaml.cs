using WalimuCareApp.ViewModels;
using Xamarin.Forms;

namespace WalimuCareApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}