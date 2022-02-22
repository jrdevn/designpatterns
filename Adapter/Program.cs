using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //PayPal payment = new PayPal();
            //payment.PayPalPayment();
            //payment.PayPalReceive();

            //  IPayPalPayment payment = new PayonnerAdapter(new Payonner());
            //  payment.PayPalPayment();
            //  payment.PayPalReceive();

            IPayPalPayment payment = new MercadoPagoAdapter(new MercadoPago());
            payment.PayPalPayment();
            payment.PayPalReceive();

            Console.ReadLine();
        }
    }
}
