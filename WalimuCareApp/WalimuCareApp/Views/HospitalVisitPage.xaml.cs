using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WalimuCareApp.Models;
using WalimuCareApp.Repositories.HospitalVisitModule;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalimuCareApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HospitalVisitPage : ContentPage
    {
        public HospitalVisitPage()
        {
            InitializeComponent();
          
        }
        private async void GetHospitalVisits()
        {
            try
            {           
                var data = await HospitalvisitRepository.GetList();

                var list = data.listOfVisits.OrderByDescending(x=>x.mvcDate).Take(6).ToList();

                if(list == null)
                {
                    await DisplayAlert("Oops !", "Something went wrong", "Cancel");
                }

                myListView.ItemsSource = list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            GetHospitalVisits();
        }
    }


}
