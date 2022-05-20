using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Middlewares
{
    public class CheckPermissionMiddleware : Middleware
    {

        private const string emailJhow = "jhonata98@hotmail.com";
        public override bool Check(string email, string password)
        {
            if (email.Equals(emailJhow))
            {
                Console.WriteLine("Seja bem vindo Jhow!");
            } else
            {
                Console.WriteLine("Seja bem vindo!");
            }

            return CheckNext(email, password);
        }
    }
}
