using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Transportation2._0
{
    class Trucking : Transportation

    {
        double weight;
        public Trucking(ITransportType vehicle, double _weight) : base(vehicle)
        {
            weight = _weight;
        }
        public override void shippingCost()
        {

        }
    }
}
