using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Jeepney : IGroundVehicle
    {
        public void Drive()
        {
            System.Console.WriteLine("Jeepney is driving");
        }
    }
}