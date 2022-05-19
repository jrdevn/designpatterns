using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Platforms
{
    public interface IPlatform
    {
        void ConfigureRMTP();
        void AuthToken();
    }
}
