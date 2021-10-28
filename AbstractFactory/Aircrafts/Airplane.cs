using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Aircrafts
{
    class Airplane : IAirCraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Pegamos os passageiros para a aeronave!");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Vamos iniciar a decolagem!");
        }
    }
}
