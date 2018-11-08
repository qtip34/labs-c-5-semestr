using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Transportation2._0
{
    abstract class Transportation
    {
        protected ITransportType transportype;

        public ITransportType TransportType
        {
            set { transportype = value; }
        }

        public Transportation(ITransportType vehicle)
        {
            transportype = vehicle;
        }

        public virtual void Time()
        {
            transportype.shippingTime();
        }
        public abstract void shippingCost();

    }
}
