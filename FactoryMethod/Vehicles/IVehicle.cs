using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Vehicles
{
    public interface IVehicle
    {
        void GetCargo();

        void StartRoute();
    }
}
