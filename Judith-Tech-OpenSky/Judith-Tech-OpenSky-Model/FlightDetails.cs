using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Judith_Tech_OpenSky_Model
{
    public class FlightDetails
    {
        public string id { get; set; }
        public string origin_country { get; set; }
        public float longitude { get; set; }
        public float latitude { get; set; } 
        public float baro_altitude { get; set; }
    }
}
