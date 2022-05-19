using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Platforms
{
    public class Dlive : IPlatform
    {
        public Dlive()
        {
            Console.WriteLine("DLive: Transmissão iniciada");
        }
        public void AuthToken()
        {
            Console.WriteLine("DLive: Autorizando aplicação...");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("DLive: Configurando RMTP..");
        }
    }
}
