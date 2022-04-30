using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Judith_Tech_OpenSky.DAL;
using Judith_Tech_OpenSky_Model;


namespace Judith_Tech_OpenSky.Entities
{
   
    public class FlightManager
    {
        private List<FlightDetails> _flightsList = new List<FlightDetails>();
        private string[] _countries;

        public bool isGetFlightDataRunning = true;

        public void Run()
        {
            Console.WriteLine($"\n\n\nFlights counter {flightsCounter()}");
            Console.WriteLine($"Last Update {LastUpdate()}");

            //Console.WriteLine("\n\nCOUNTRIES LIST: ");
            //GetCountriesNames();

            //Console.WriteLine("\n\nTOP #5 COUNTRIES: ");
            //TopFiveCountries();

            //Console.WriteLine("\n\n Flights");
            //DisplayCountriesFlights("Germany");

            var flight_details = HighestFlight();
            Console.WriteLine($"\n\n Highest flight \n " +
                $"{flight_details.id} \n " +
                $"{flight_details.origin_country} \n " +
                $"{flight_details.longitude} \n " +
                $"{flight_details.latitude} \n " +
                $"{flight_details.baro_altitude}");

            var min_flight_details = LowestFlight();
            Console.WriteLine($"\n\n Lowest flight \n " +
                $"{min_flight_details.id} \n " +
                $"{min_flight_details.origin_country} \n " +
                $"{min_flight_details.longitude} \n " +
                $"{min_flight_details.latitude} \n " +
                $"{min_flight_details.baro_altitude}");
        }

        public Task GetFlightData()
        {
            Task task =  Task.Factory.StartNew(() => {
                while(isGetFlightDataRunning)
                {
                    System.Threading.Thread.Sleep(10000);
                    SaveFlightData();
                }
            });
            return task;
        }

        public async void SaveFlightData()
        {
            APIFlightRequest APIFlightRequest = new APIFlightRequest();
            var flights = await APIFlightRequest.GetFlightDataFromAPI();
            
            foreach (var flight in flights.states)
            {
                FlightDetails flightDetails = new FlightDetails();

                flightDetails.id = flight[0].ToString();
                flightDetails.origin_country = flight[2].ToString();

                if(flight[5] != null)   
                    flightDetails.latitude = float.Parse(flight[5].ToString());

                if (flight[6] != null)
                    flightDetails.longitude = float.Parse(flight[6].ToString());

                if (flight[7] != null)
                    flightDetails.baro_altitude = float.Parse(flight[7].ToString());

                _flightsList.Add(flightDetails);
            }

            Run();
        }

        public int flightsCounter()
        {
            var flightsCounter = from flight in _flightsList.ToArray()
                                 select flight;

            int count = flightsCounter.ToArray().Length;
            return count;
        }

        public string LastUpdate()
        {
            DateTime dt = DateTime.Now;
            return $"{dt.ToString("d")} {dt.ToString("T")}"; 
        }

        public string[] GetCountriesNames()
        {
            var names = from flight in _flightsList
                        orderby flight.origin_country
                        select flight.origin_country;

            string[] countriesNames =  names.Distinct().ToArray();

            foreach (string country in countriesNames)
                Console.WriteLine(country);

            _countries = countriesNames;

            return countriesNames;
        }

        private int[] CountFlightInEachCountry()
        {
            int[] flightCounter = new int[_countries.Length];

            foreach(var flight in _flightsList)
            {
                for(int i = 0; i < flightCounter.Length; i++)
                {
                    if (flight.origin_country == _countries[i])
                        flightCounter[i]++;
                }
            }
            return flightCounter;
        }

        public string[] TopFiveCountries()
        {
            int[] numOfFlightInEachCountry = CountFlightInEachCountry();
            string[] top5 = new string[5];
            int j = 0;
           
            while(j < top5.Length)
            {
                int max = numOfFlightInEachCountry[0], maxIndex = 0;

                for (int i = 1; i < numOfFlightInEachCountry.Length; i++)
                    if (numOfFlightInEachCountry[i] > max && numOfFlightInEachCountry[i] != -1)
                    {
                        max = numOfFlightInEachCountry[i];
                        maxIndex = i;
                    }

                numOfFlightInEachCountry[maxIndex] = -1;

                top5[j] = _countries[maxIndex];
                j++;
            }

            foreach(string name in top5)
                Console.WriteLine(name);

            return top5;
        }

        public FlightDetails[] DisplayCountriesFlights(string name)
        {
            var flights = from flight in _flightsList
                          where flight.origin_country == name
                          select flight;

            foreach(var flight in flights.ToArray())
                Console.WriteLine($"{flight.origin_country}   {flight.id}");


            return flights.ToArray();
        }

        public FlightDetails DisplayFlightDetails(string flight_id)
        {
            var flight = from flightDetail in _flightsList
                         where flightDetail.id == flight_id
                         select flightDetail;

            return flight.ToArray()[0];
        }

        public FlightDetails HighestFlight()
        {
            List<FlightDetails> flights = _flightsList;
            var max = flights.OrderByDescending(flight => flight.baro_altitude).First();

            return max;
        }

        public FlightDetails LowestFlight()
        {
            List<FlightDetails> flights = _flightsList;
            var min = flights.OrderBy(flight => flight.baro_altitude).First();
            return min;
        }
    }
}
