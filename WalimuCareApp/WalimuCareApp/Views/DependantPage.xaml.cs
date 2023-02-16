using Newtonsoft.Json;
using Plugin.Toast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WalimuCareApp.Models;
using WalimuCareApp.Repositories.DependantsModule;
using WalimuCareApp.Repositories.HospitalVisitModule;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalimuCareApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DependantPage : ContentPage
    {
        public DependantPage()
        {
            InitializeComponent();           
        }      

        private async void GetDependants()
        {
            try
            {
                var data = await DependantRepository.GetList();

                if (data == null)
                {
                   await DisplayAlert("Oops !", "Sorry you have no dependatns", "Cancel");
                }

                listOfDependants.ItemsSource = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        protected override void OnAppearing()
        {
            base.OnAppearing();

            //var dependants = new List<Dependant>
            //{
            //    new Dependant{ MemberNumber="20133" ,FirstName="Peter",LastName="Kachezi" ,PhoneNumber="0704509484"},
            //    new Dependant{ MemberNumber="20133" ,FirstName="Peter",LastName="Kachezi" ,PhoneNumber="0704509484"},
            //    new Dependant{ MemberNumber="20133" ,FirstName="Peter",LastName="Kachezi" ,PhoneNumber="0704509484"},
            //    new Dependant{ MemberNumber="20133" ,FirstName="Peter",LastName="Kachezi" ,PhoneNumber="0704509484"},
            //    new Dependant{ MemberNumber="20133" ,FirstName="Peter",LastName="Kachezi" ,PhoneNumber="0704509484"},
            //    new Dependant{ MemberNumber="20133" ,FirstName="Peter",LastName="Kachezi" ,PhoneNumber="0704509484"},
            //    new Dependant{ MemberNumber="20133" ,FirstName="Peter",LastName="Kachezi" ,PhoneNumber="0704509484"},
            //    new Dependant{ MemberNumber="20133" ,FirstName="Peter",LastName="Kachezi" ,PhoneNumber="0704509484"},

            //};

           GetDependants();
        }

        private void msgErro_Clicked(object sender, EventArgs e)
        {
            CrossToastPopUp.Current.ShowToastError("There are no dependnats");

        }
    }
}
