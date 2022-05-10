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
    }
}
