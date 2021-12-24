using System;
using System.Collections.Generic;
using System.Text;

namespace Vlados_5
{
    interface IDevice
    {
        bool Power
        {
            get;
            set;
        }

        void Power_on();

        void Power_off();
    }
}
