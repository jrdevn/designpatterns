using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Platforms
{
    public class Facebook : IPlatform
    {
        public Facebook()
        {
            Console.WriteLine("Facebook: Transmissão iniciada...");

        }
        public void AuthToken()
        {
            Console.WriteLine("Facebook: Autorizando aplicação...");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: Configurando RMTP..");

        }
    }
}
