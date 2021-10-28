using FactoryMethod.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    class CarTransport : Transport

    {
        protected override IVehicle CreateTransport()
        {
            return new Car();
        }
    }
}
