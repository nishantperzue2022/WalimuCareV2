using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalimuCareApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelemedicinePage : ContentPage
    {
        public ObservableCollection<Card> listDetails { get; set; }
        public TelemedicinePage()
        {
            InitializeComponent();

            GetDependants();
        }

        private void GetDependants()
        {
            listDetails = new ObservableCollection<Card>()
            {
                new Card() { ImgIcon="dependantsIcon.png",Name="IT Department"},
                new Card() { ImgIcon="dependantsIcon.png",Name="IT Biological Science"},
                new Card() { ImgIcon="dependantsIcon.png",Name="IT Education"},
                new Card() { ImgIcon="dependantsIcon.png",Name="IT Accounts"}
            };

            BindingContext = this;
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



        public class Card
        {
            public string ImgIcon { get; set; }
            public string Name { get; set; }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var pop = new MessageBoxPage();

            App.Current.MainPage.Navigation.PushPopupAsync(pop, true);
        }
    }
}