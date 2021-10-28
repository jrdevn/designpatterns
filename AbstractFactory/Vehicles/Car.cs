using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Vehicles
{
    class Car : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Peguei os passageiros");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos a rota com o carro!");
        }
    }
}
