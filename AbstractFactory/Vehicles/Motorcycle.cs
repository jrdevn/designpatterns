using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Vehicles
{
    class Motorcycle : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Estamos iniciando a entrega desta encomenda!");
        }
    }
}
