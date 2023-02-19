using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WalimuCareApp.Models;
using WalimuCareApp.Utils;
using static WalimuCareApp.Models.Dependant;
using System.Reflection;
using Xamarin.Essentials;

namespace WalimuCareApp.Repositories.DependantsModule
{
    public static class DependantRepository
    {
        public static async Task<List<Dependant>> GetList()
        {
            try
            {
                var memberNo = Preferences.Get("memberName", string.Empty);

                var client = new HttpClient();

                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage getData = await client.GetAsync(MaklAPI.ApiUrl + "api/Dependants/MemberNo?MemberNo=" + memberNo + "");

                if (getData.IsSuccessStatusCode)
                {
                    string results = getData.Content.ReadAsStringAsync().Result;

                    var getDependants = JsonConvert.DeserializeObject<List<Dependant>>(results);

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
