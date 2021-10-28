using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Aircrafts
{
    interface IAirCraft // poderia haver abstrações também como IHelicopter, IAirplane
    {
        void StartRoute();
        void GetCargo();
        void CheckWind();
    }
}
