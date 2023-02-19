using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using WalimuCareApp.Models;
using WalimuCareApp.Utils;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace WalimuCareApp.Repositories.HospitalVisitModule
{
    public static class HospitalvisitRepository
    {
        public static async Task<root> GetList()
        {
            try
            {
                var memberNo = Preferences.Get("memberName", string.Empty);

                var client = new HttpClient();

                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage getData = await client.GetAsync(MaklAPI.ApiUrl + "api/HospitalVisits/MemberNo?MemberNo="+ memberNo + "");

                if (getData.IsSuccessStatusCode)
                {
                    string results = getData.Content.ReadAsStringAsync().Result;

                    var getDependants = JsonConvert.DeserializeObject<root>(results);

                    return getDependants;
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

    }
}
