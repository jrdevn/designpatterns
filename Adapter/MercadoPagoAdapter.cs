using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class MercadoPagoAdapter : IPayPalPayment
    {
        private MercadoPago mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
        }
        public Token authToken()
        {
            return this.mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            this.mercadoPago.SendPaymentWithMercadoPago();
        }

        public void PayPalReceive()
        {
            this.mercadoPago.ReceivePaymentWithMercadoPago();

        }
    }
}
