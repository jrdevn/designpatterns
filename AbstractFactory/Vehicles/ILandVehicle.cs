using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Vehicles
{
    interface ILandVehicle // poderia haver abstrações também como ICar, IMotocycle
    {
        void StartRoute();

        void GetCargo();
    }
}
