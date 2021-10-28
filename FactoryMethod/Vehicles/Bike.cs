using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Vehicles
{
    public class Bike : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Peguei a encomenda leve");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Vamos seguir a rota normalmente");
        }
    }
}
