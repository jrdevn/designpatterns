using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Aircrafts
{
    class Drone : IAirCraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Conferindo os ventos para não estragar a parte eletronica!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Pegando as mercadorias!");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Vamos sobrevoar com o drone!");
        }
    }
}
