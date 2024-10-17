using System;
namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main()
        {
            Seaplane seaplane = new Seaplane();
            seaplane.Navigate();
            seaplane.Fly();

            Boat boat = new Boat();
            boat.Navigate();

            Airplane airplane = new Airplane();
            airplane.Fly();

            Jeepney jeepney = new Jeepney();
            jeepney.Drive();
        }
    }
}