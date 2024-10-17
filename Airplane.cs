using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Airplane : IAerialVehicle
    {
        public void Fly()
        {
            System.Console.WriteLine("Airplane is flying");
        }
    }
}