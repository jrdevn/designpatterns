using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Payonner : IPayonnerPayment
    {
        private Token _token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            _token = AuthToken();
            Console.WriteLine("Recebendo pagamentos com Payonnner");
        }

        public void SendPayment()
        {
            _token = AuthToken();
            Console.WriteLine("Enviando pagamentos com Payonnner");
        }
    }
}
