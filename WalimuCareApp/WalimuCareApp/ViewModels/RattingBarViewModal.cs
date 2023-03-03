using Android.Widget;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WalimuCareApp.Models;
using WalimuCareApp.Utils;
using WalimuCareApp.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WalimuCareApp.ViewModels
{
    public class RattingBarViewModal : AppViewModel
    {

        public ICommand ClickCommand { get; set; }
        public ICommand ComplainCommand { get; set; }

        //public ICommand TapCommand
        public RattingBarViewModal()
        {
            // ClickCommand = new Command(OnComplaint());
            // 
            ComplainCommand = new Command(async () => await ComplainLorge());

        }
        public async Task ComplainLorge()
        {
            await Shell.Current.GoToAsync(nameof(SubmitComplaintsPage));
        }
        //public async void OnButtonClicked(object sender, EventArgs args)
        //{
        //    await Pedistole(sender, args);
        //}
        //private Task Pedistole(object sender, EventArgs args)
        //{
        //    Console.WriteLine(sender);
        //    throw new NotImplementedException();
        //}
        public async void OnComplaint()
        {
            await Shell.Current.GoToAsync(nameof(SubmitComplaintsPage));
        }
        public async void OnClicked(object obj, EventArgs args)
        {
            RattingBar b = (RattingBar)obj;
            // App.Current.MainPage.DisplayAlert("Selected Value is guts", b.SelectedStarValue.ToString(), "OK");
            ///Complaints/SubmitReview
            try
            {


                //await ShowLoadingMessage();

                RestClient client = new RestClient(ApiDetail.EndPoint);

                RestRequest restRequest = new RestRequest()
                {
                    Resource = "/Complaints/Review",
                    Method = Method.Post
                };

                var barry = new
                {
                    memberId = Preferences.Get(nameof(AspNetUsers.memberId), ""),
                    date = DateTime.Now,
                    rateGiven = b.SelectedStarValue.ToString(),
                    description = RatingDescription
                };

                restRequest.AddJsonBody(barry);

                var response = await client.ExecuteAsync(restRequest);

                if (response.IsSuccessful)
                {
                    //await ShowSuccessMessage("Your Issue has been Submitted successfully kindly await a call in 30 minutes");



                    // await Task.Delay(2000);

                    //await GetMemberComplaints();

                    await Shell.Current.GoToAsync(nameof(ComplaintsPage));


                }
                else
                {
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private string _selectedStar;
        //public event PropertyChangedEventHandler PropertyChanged;
        //protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        private string ratingDescription;
        public string RatingDescription
        {
            get { return ratingDescription; }
            set { ratingDescription = value; OnPropertyChanged(); }
        }

        public string SelectedStar
        {
            get { return _selectedStar; }
            set { _selectedStar = value; OnPropertyChanged(); }
        }

    }
}
