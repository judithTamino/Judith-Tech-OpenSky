using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Judith_Tech_OpenSky.DAL;
using Judith_Tech_OpenSky_Model;

namespace Judith_Tech_OpenSky.Entities
{
    public class DataHandler
    {
        public bool isGetFlightDataRunning = true;
        private List<FlightDetails> _flights = new List<FlightDetails>();
        private string[] _countries;

        public delegate void delLoadData();
        public event delLoadData HandlerLoadData;

        public Task SaveFlights()
        {
            return Task.Factory.StartNew(async () => {
                while (isGetFlightDataRunning)
                {
                    var flights = await new ApiRequest().GetFlightDataFromAPI();
                    List<FlightDetails> temp = new List<FlightDetails>();

                    foreach (var flight in flights.states)
                    {
                        FlightDetails flightDetails = new FlightDetails(flight[0], flight[2], flight[5], flight[6], flight[7]);
                        temp.Add(flightDetails);
                    }
                    _flights = temp;
                    HandlerLoadData();

                    System.Threading.Thread.Sleep(30000);
                }
            });
        }

        public int GetNumOfFlights()
        {
           return _flights.Count; 
        }

        public string GetLastUpdate()
        {
            return $"{DateTime.Now.ToString("d")} {DateTime.Now.ToString("T")}";
        }

        public string[] GetCountriesName()
        {
            var countries = from country in _flights
                            orderby country._origin_country
                            select country._origin_country;

            _countries = countries.Distinct().ToArray();
            return _countries;
        }
    }
}
