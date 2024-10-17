using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Boat : IMarineVehicle
    {
        public void Navigate()
        {
            System.Console.WriteLine("Boat is navigating");
        }
    }
}