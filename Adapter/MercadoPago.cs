using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class MercadoPago
    {
        private Token _token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePaymentWithMercadoPago()
        {
            _token = AuthToken();
            Console.WriteLine("Recebendo o pagamento do Mercado Pago! Com taxa :/");
        }

        public void SendPaymentWithMercadoPago()
        {
            _token = AuthToken();
            Console.WriteLine("Enviando pagamentos do Mercado Pago! Com taxa bad :(");
        }

    }
}
