using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Transportation2._0
{
    class Bike : ITransportType

    {
        double distance;

        public double capacity = 70;
        //public double distance { get; }
        public double speed { get { return 25; } }
        public double efficiency { get { return 1000; } } // hrn/(kg * km)

        public Bike(double _distance)
        {
            distance = _distance;
        }

        public void shippingTime()
        {
            //Console.WriteLine("Shipping time by bike : " + (distance / speed));           
        }
        //cost = (distance * weight) /efficiency

    }
}
