using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class PayPal : IPayPalPayment
    {
        private Token _token;
        public Token authToken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            _token = authToken();
            Console.WriteLine("Enviando pagamento com PayPal");
        }

        public void PayPalReceive()
        {
            Console.WriteLine("Recebendo pagamento com PayPal");
        }
    }
}
