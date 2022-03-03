using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencies_NET.model
{
    interface IIdentifiable<TID>
    {
        TID getID();
        void setID(TID ID);
    }
}
