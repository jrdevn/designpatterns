using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Middlewares
{
    public class CheckWeakPasswordMiddleware : Middleware
    {
        private const string keyWeak = "123456";
        public override bool Check(string email, string password)
        {
            if (password == keyWeak)
            {
                Console.WriteLine("Senha fraca! altere sua senha!");
            }
            return CheckNext(email, password);
        }
    }
}
