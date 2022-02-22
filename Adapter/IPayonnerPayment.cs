using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    interface IPayonnerPayment
    {
        Token AuthToken();
        void SendPayment();
        void ReceivePayment();
    }
}
