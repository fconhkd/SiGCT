using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGCT.Domain.Contracts
{
    public interface IRepository<T> : IDisposable
         where T : class
    {
        ICollection<T> Get();
        T Get(long id);
        void SaveOrUpdate(T entity);
        void Delete(long id);
    }
}
