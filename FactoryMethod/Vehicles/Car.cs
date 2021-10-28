using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Vehicles
{
    public class Car : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos os passageiros");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciou a rota com o carro");
        }
    }
}
