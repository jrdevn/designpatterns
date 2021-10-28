using AbstractFactory.Aircrafts;
using AbstractFactory.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    class UberTransport : ITransportFactory
    {
        public IAirCraft CreateTransportAirCraft()
        {
            return new Airplane();
        }

        public ILandVehicle CreateTransportVehicle() 
        {
            return new Car();
        }
    }
}
