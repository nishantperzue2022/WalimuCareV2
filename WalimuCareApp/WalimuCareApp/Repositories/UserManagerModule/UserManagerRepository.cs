using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WalimuCareApp.Models;
using WalimuCareApp.Utils;
using Xamarin.Essentials;

namespace WalimuCareApp.Repositories.UserManagerModule
{
    public static class UserManagerRepository
    {
        public static async Task<bool> RegisterUser(string MemberNo, string FirstName, string LastName, string email, string password)
        {
            try
            {
                var register = new Register()
                {
                    Email = email,

                    MemberNumber = MemberNo,

                    FirstName = FirstName,

                    LastName = LastName,

                    Password = password,
                };

                var httpClient = new HttpClient();

                var json = JsonConvert.SerializeObject(register);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(MaklAPI.ApiUrl + "api/MemberAuth", content);

                if (!response.IsSuccessStatusCode)
                {
                    return false;
                }

                Preferences.Set("memberNo", MemberNo);


                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }
        public static async Task<bool> Login(string email, string password)
        {
            try
            {
                var login = new Login()
                {
                    Email = email,

                    Password = password,
                };

                var httpClient = new HttpClient();

                var json = JsonConvert.SerializeObject(login);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(MaklAPI.ApiUrl + "api/MemberAuth/Login", content);

                if (!response.IsSuccessStatusCode)
                {
                    return false;
                }
                var JsonResult = await response.Content.ReadAsStringAsync(); // reponse from api

                var result = JsonConvert.DeserializeObject<Token>(JsonResult); // deserialize json to c #

                Preferences.Set("accessToken", result.access_token);// saving reponse locally in essesials for validation

                Preferences.Set("userId", result.user_Id);

                Preferences.Set("userName", result.user_name);

                Preferences.Set("tokenExpirationTime", result.expiration_Time);

                Preferences.Set("currentTime", DateTimeOffset.Now.ToUnixTimeSeconds());

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }
    }
}
