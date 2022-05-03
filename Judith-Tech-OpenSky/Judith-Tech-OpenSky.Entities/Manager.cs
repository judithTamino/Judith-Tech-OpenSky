using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Judith_Tech_OpenSky.Entities
{

    public class Manager
    {
        public DataHandler DataHandler = new DataHandler();
        public void RunAll()
        {
            DataHandler.SaveFlights();
        }

      
        /* public delegate void delLoadFlight();
public event delLoadFlight HandleLoadFlight;

private List<FlightDetails> _flightsList = new List<FlightDetails>();
private string[] _countries;

public bool isGetFlightDataRunning = true;
public Task GetFlightData()
{
Task task =  Task.Factory.StartNew(() => {
while(isGetFlightDataRunning)
{
   SaveFlights();
   System.Threading.Thread.Sleep(10000);
}
});
return task;
}

public async void SaveFlights()
{
ApiRequest flightRequest = new ApiRequest();
var flights = await flightRequest.GetFlightDataFromAPI();

List<FlightDetails> tempFlightList = new List<FlightDetails>();

foreach (var flight in flights.states)
{
FlightDetails flightDetails = new FlightDetails();

flightDetails.id = flight[0].ToString();
flightDetails.origin_country = flight[2].ToString();

if (flight[5] != null)
   flightDetails.latitude = float.Parse(flight[5].ToString());

if (flight[6] != null)
   flightDetails.longitude = float.Parse(flight[6].ToString());

if (flight[7] != null)
   flightDetails.baro_altitude = float.Parse(flight[7].ToString());

tempFlightList.Add(flightDetails);
}

_flightsList = tempFlightList;
HandleLoadFlight();
}


// func => get numbers of flights
public int GetNumberOfFlights()
{
return _flightsList.Count;
//System.Threading.Thread.Sleep(10000);
}

// func => return tha last time there was a request to the api
public string LastUpdate()
{
DateTime dt = DateTime.Now;
return $"{dt.ToString("d")} {dt.ToString("T")}"; 
}

// func => return countries name
public string[] GetCountriesNames()
{
var names = from flight in _flightsList
       orderby flight.origin_country
       select flight.origin_country;

string[] countries = names.Distinct().ToArray();
_countries = countries;

return countries;
}

private int[] CountFlightInEachCountry()
{
int[] flightCounter = new int[_countries.Length];

foreach(var flight in _flightsList)
{
for(int i = 0; i < flightCounter.Length; i++)
   if (flight.origin_country == _countries[i])
       flightCounter[i]++;
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
return top5;
}

public FlightDetails[] DisplayCountriesFlights(string name)
{
var flights = from flight in _flightsList
         where flight.origin_country == name
         select flight;

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
}*/
    }
}
