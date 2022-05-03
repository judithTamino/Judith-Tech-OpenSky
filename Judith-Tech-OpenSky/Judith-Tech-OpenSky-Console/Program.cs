using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Judith_Tech_OpenSky.Entities;

namespace Judith_Tech_OpenSky_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Manager manager = new Manager();
           manager.RunAll();

            Console.WriteLine(manager._numFlights);
            Console.ReadLine();
        }
    }
}
