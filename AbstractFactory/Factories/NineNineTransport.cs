using AbstractFactory.Aircrafts;
using AbstractFactory.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    class NineNineTransport : ITransportFactory
    {
        public IAirCraft CreateTransportAirCraft()
        {
            return new Helicopter();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new Motorcycle();
        }

    }
}
