using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation2._0
{
    interface ITransportType
    {
        double distance { get; }
        double speed { get; }
        double efficiency { get; }
        void shippingTime();
    }
}
