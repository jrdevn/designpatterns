using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.App
{
    class Application
    {
        private IAirCraft airCraft;
        private ILandVehicle landVehicle;


        public Application(ITransportFactory transportFactory )
        {
            airCraft = transportFactory.CreateTransportAirCraft();
            landVehicle = transportFactory.CreateTransportVehicle();
        }

        public void StartRouteApp()
        {
            landVehicle.StartRoute();
            airCraft.StartRoute();
        }
    }
}
