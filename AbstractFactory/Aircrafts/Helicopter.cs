using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Aircrafts
{
    class Helicopter : IAirCraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando o vento e as hélices!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros ok! Ligando as hélices");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem com o helicoptero!");
        }
    }
}
