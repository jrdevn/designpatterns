using AbstractFactory.Aircrafts;
using AbstractFactory.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    interface ITransportFactory
    {
        IAirCraft CreateTransportAirCraft();
        ILandVehicle CreateTransportVehicle();
    }
}
