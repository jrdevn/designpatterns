using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Platforms
{
    public class TwitchTV : IPlatform
    {
        public TwitchTV()
        {
            Console.WriteLine("TwitchTV: Transmissão iniciada...");

        }
        public void AuthToken()
        {
            Console.WriteLine("TwitchTV: Autorizando aplicação...");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("TwitchTV: Configurando RMTP..");

        }
    }
}
