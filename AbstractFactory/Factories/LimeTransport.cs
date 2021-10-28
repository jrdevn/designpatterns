using AbstractFactory.Aircrafts;
using AbstractFactory.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    class LimeTransport : ITransportFactory
    {
        public IAirCraft CreateTransportAirCraft()
        {
            return new Drone();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new Scooter();
        }
    }
}
