using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Vehicles
{
    class Scooter : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando sacolas e verificando a rodinha do patinete!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Saindo na rota com o patinete!");
        }
    }
}
