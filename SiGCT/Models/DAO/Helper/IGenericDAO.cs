using System;
using System.Collections.Generic;

namespace SiGCT.Models.DAO
{
    interface IGenericDAO<T>
    {
        void delete(T o);

        IList<T> listAll();

        T getById(Int32 id);

        void save(IList<T> o);

        void save(T o);

        void update(T o);
    }
}
