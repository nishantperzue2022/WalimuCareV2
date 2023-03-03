using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;
using WalimuCareApp.ApiResponses;
using WalimuCareApp.Models;
using WalimuCareApp.Utils;
using Xamarin.Forms;

namespace WalimuCareApp.ViewModels
{
    public class FaqsViewModel :AppViewModel
    {
        private List<FAQ> myFAQs;
        public List<FAQ> MyFAQs
        {
            get { return myFAQs; }

            set { myFAQs = value; OnPropertyChanged(); }
        }

        private List<FaqBase> faqBases;
        public List<FaqBase> FaqBases
        {
            get { return faqBases; }

            set { faqBases = value; OnPropertyChanged(); }
        }

        public ICommand GetFaqsCommand { get; set; }

        public FaqsViewModel()
        {
            GetFaqsCommand = new Command(async () => await GetFaqs());

            Task.Run(async () =>
            {
                await GetFaqs();
            });
        }

        public async Task GetFaqs()
        {
            try
            {
                var client = new HttpClient();

                if (await CheckInternetConnectivity())
                {
                    if (!await CheckIfApiDetailsAreSetUp())
                    {

                    }
                    else
                    {
                        IsRefreshing = true;

                        await Task.Delay(2000);

                        FaqBases = new List<FaqBase>();

                        await ShowLoadingMessage();               

                        HttpResponseMessage getData = await client.GetAsync(MaklAPI.PublicEndPoint + "Complaints/GetFAQs");

                        if (getData.IsSuccessStatusCode)
                        {
                            string results = getData.Content.ReadAsStringAsync().Result;

                            var deserializedResponse = JsonConvert.DeserializeObject<BaseResponse<List<FaqBase>>>(results);

                            if (deserializedResponse.success)
                            {
                                FaqBases = deserializedResponse.data;
                                await RemoveLoadingMessage();
                            }
                            else
                            {
                                await ShowErrorMessage("Sorry, no FAQs were found");
                            }
                        }
                        else
                        {
                            await ShowErrorMessage();
                        }
                    }
                }

                IsRefreshing = false;
            }
            catch (Exception ex)
            {
                SendErrorMessageToAppCenter(ex, "FAQ");
            }
        }
    }
}
