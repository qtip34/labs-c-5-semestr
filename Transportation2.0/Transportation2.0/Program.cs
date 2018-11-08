using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation2._0
{ 
    class MainApp

    {
        static void Main()
        {
            //TransportType bike = new Bike(new Trucking());
            Transportation first = new Trucking(new Bike(5), 54 ); //weight/number);
            first.shippingCost();
            
            //first.TransportType = new Wagon();
        }
    }
    
}
