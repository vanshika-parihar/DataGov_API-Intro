using DataGov_API_Intro.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace DataGov_API_Intro.Controllers
{
    public class HomeController : Controller
    {
        HttpClient httpClient;
        //https://api.usa.gov/crime/fbi/sapi/api/summarized/estimates/national/2000/2019?api_key=o3YgxPhIta2frQCDcfIZQSNsBqOBAAXWP9nD8M8g
        static string BASE_URL = "https://api.usa.gov/crime/fbi/sapi/";
        static string API_KEY = "g1mjvzQVDzMmHo0UQgfjLMgV4pzyazleokQOM5XS";

        public IActionResult Index()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            // string FBI_DATA_API_PATH = BASE_URL + "api/participation/national";
            string FBI_DATA_API_PATH = BASE_URL + "api/summarized/estimates/national/2000/2019?";

            string resultsData = "";

            Results results = null;

            httpClient.BaseAddress = new Uri(FBI_DATA_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(FBI_DATA_API_PATH).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    resultsData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!resultsData.Equals(""))
                {
                    results = JsonConvert.DeserializeObject<Results>(resultsData);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return View(results);
        }
    }
}







