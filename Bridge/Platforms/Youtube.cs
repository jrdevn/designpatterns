using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Platforms
{
    public class Youtube : IPlatform
    {
        public Youtube() 
        {
            Console.WriteLine("Youtube: Transmissão iniciada...");

        }
        public void AuthToken()
        {
            Console.WriteLine("Youtube: Autorizando aplicação...");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Youtube: Configurando RMTP..");

        }
    }
}
