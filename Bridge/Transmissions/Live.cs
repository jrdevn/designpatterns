using Bridge.Platforms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Transmissions
{
    public class Live : ITransmission
    {
        protected IPlatform _platform;
        public Live(IPlatform platform)
        {
            _platform = platform;
        }

        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissão na plataforma: {_platform}");
        }

        public void Result()
        {
            Console.WriteLine("***** ON AIR *******");
        }
    }
}
