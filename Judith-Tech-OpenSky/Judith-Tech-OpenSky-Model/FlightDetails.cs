using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Judith_Tech_OpenSky_Model
{
    public class FlightDetails
    {
        public FlightDetails(object id, object country, object longitude, object latitude, object baro_altitude)
        {
            _id = id.ToString();
            _origin_country = country.ToString();

            if(longitude != null)
                _longitude = float.Parse(longitude.ToString());
            if(latitude != null)
                _latitude = float.Parse(latitude.ToString());
            if(baro_altitude != null)
                _baro_altitude = float.Parse(baro_altitude.ToString());
        }
        public string _id { get; set; }
        public string _origin_country { get; set; }
        public float _longitude { get; set; }
        public float _latitude { get; set; } 
        public float _baro_altitude { get; set; }
    }
}
