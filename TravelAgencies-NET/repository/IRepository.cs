using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencies_NET.model;

namespace TravelAgencies_NET.repository
{
    interface IRepository<T,TID> where T : IIdentifiable<TID>
    {
        void Save(T elem);

        void Delete(T elem);

        void Update(T elem, TID ID);

        T FindById(TID ID);

        IEnumerable<T> FindAll();
    }
}
