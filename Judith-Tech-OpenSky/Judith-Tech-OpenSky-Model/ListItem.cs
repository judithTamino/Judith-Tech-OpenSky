using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Judith_Tech_OpenSky_Model
{
    public class ListItem
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Value + " " + Name;
        }
    }
}
