using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using Judith_Tech_OpenSky_Model;

namespace Judith_Tech_OpenSky.DAL
{
    public class ApiRequest
    {
        public async Task<Flights> GetFlightDataFromAPI()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://opensky-network.org/api/");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Get Request
            HttpResponseMessage response = client.GetAsync("states/all").Result; // program will wait here until a response is received
            if(response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                var flightData = JsonSerializer.Deserialize<Flights>(data); 
                return flightData;
            }
            return null;
        }
    }
}
