using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WalimuCareApp.Models;
using WalimuCareApp.Utils;
using Xamarin.Essentials;
using static WalimuCareApp.Models.FAQ;

namespace WalimuCareApp.Repositories.FAQsModule
{
    public static class FAQsRepository
    {
		//public static async Task<List<Class1>> GetList()
		//{
		//	try
		//	{
		//		//var memberNo = Preferences.Get("memberName", string.Empty);

		//		var client = new HttpClient();

		//		client.DefaultRequestHeaders.Accept.Clear();

		//		client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

		//		HttpResponseMessage getData = await client.GetAsync(MaklAPI.ApiUrl + "api/FAQs/GetFAQs");

		//		if (getData.IsSuccessStatusCode)
		//		{
		//			string results = getData.Content.ReadAsStringAsync().Result;

		//			var getDependants = JsonConvert.DeserializeObject<List<Class1>>(results);

		//			return getDependants;
		//		}

		//		return null;
		//	}
		//	catch (Exception ex)
		//	{
		//		Console.WriteLine(ex.Message);

		//		return null;
		//	}
		//}

	}
}
