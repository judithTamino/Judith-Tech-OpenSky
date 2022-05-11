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
                            where country._origin_country != ""
                            orderby country._origin_country
                            select country._origin_country;

            _countries = countries.Distinct().ToArray();
            return _countries;
        }

        private int[] CountNumbersOfFlightsInEachCountry()
        {
            int[] flightCounter = new int[_countries.Length];
            foreach (var country in _flights)
                for (int i = 0; i < flightCounter.Length; i++)
                    if(country._origin_country == _countries[i])
                        flightCounter[i]++;
            return flightCounter;
        }

        public string[] TopFiveCountries()
        {
            int[] numberOfFlightInEachCountry = CountNumbersOfFlightsInEachCountry();
            string[] topFiveCountries = new string[5];

            int index = 0;
            while(index < topFiveCountries.Length)
            {
                int max = numberOfFlightInEachCountry[0], maxIndex = 0;
                for (int i = 1; i < numberOfFlightInEachCountry.Length; i++)
                    if(numberOfFlightInEachCountry[i] > max)
                    {
                        max = numberOfFlightInEachCountry[i];
                        maxIndex = i;
                    }
                numberOfFlightInEachCountry[maxIndex] = -1;

                topFiveCountries[index] = _countries[maxIndex];
                index++;
            }
            return topFiveCountries;
        }

        public FlightDetails[] GetAllFlightsOfSelectedCountry(string name)
        {
            var flights = from flight in _flights
                          where flight._origin_country == name
                          select flight;

            return flights.ToArray();
        }

        public FlightDetails GetFlightDetails(string id)
        {
            var flight = from flightDetails in _flights
                         where flightDetails._id == id
                         select flightDetails;

            return flight.ToArray()[0];
        }

        public string GetHighestFlightId()
        {
            List<FlightDetails> temp = _flights;

            var highestFlight = temp.OrderByDescending(flight => flight._baro_altitude).First();
            return highestFlight._id;
        }

        public string GetLowestFlightId()
        {
            List<FlightDetails> temp = _flights;
            var lowestFlight = temp.OrderBy(flight => flight._baro_altitude).First();

            return lowestFlight._id;
        }

        public FlightDetails[] Refresh(float top, float bottom, float left, float right)
        {
            var flightsArr = from flight in _flights
                             where flight._latitude > left && flight._latitude < right && flight._longitude < top && flight._longitude > bottom
                             select flight;

            return flightsArr.ToArray();
        }
    }
}
