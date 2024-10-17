using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Seaplane : IAerialVehicle, IMarineVehicle
    {
        public void Fly()
        {
            System.Console.WriteLine("Seaplane is flying");
        }

        public void Navigate()
        {
            System.Console.WriteLine("Seaplane is navigating");
        }
    }
}