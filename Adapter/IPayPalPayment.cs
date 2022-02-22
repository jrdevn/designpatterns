using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    interface IPayPalPayment
    {
        Token authToken();
        void PayPalPayment();
        void PayPalReceive();
    }
}
