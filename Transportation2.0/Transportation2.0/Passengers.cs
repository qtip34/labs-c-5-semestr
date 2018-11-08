using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Transportation2._0
{
    class Passengers : Transportation

    {
        int numberOfPassengers;
        public Passengers(ITransportType vehicle, int _number) : base(vehicle)
        {
            numberOfPassengers = _number;
        }
        public override void shippingCost()
        {
            //cost = (distance * weight) /efficiency
            Console.WriteLine("Shipping cost : " + transportype);
        }
    }
}
