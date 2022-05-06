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

      
 /* 
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
