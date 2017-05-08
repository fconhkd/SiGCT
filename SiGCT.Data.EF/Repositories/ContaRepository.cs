using SiGCT.Data.EF.DataContexts;
using SiGCT.Domain.Contracts;
using SiGCT.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGCT.Data.EF.Repositories
{
    public class ContaRepository : IRepository<Conta>
    {
        private SigctDataContext _db;

        public ContaRepository(SigctDataContext context)
        {
            _db = context;
        }

        public void Delete(long id)
        {
            _db.Conta.Remove(_db.Conta.Find(id));
            _db.SaveChanges();
        }

        public ICollection<Conta> Get()
        {
            return _db.Conta.ToList();
        }

        public Conta Get(long id)
        {
            return _db.Conta.Find(id);
        }

        public void SaveOrUpdate(Conta entity)
        {
            if (entity.Id == 0)
                _db.Conta.Add(entity);
            else
                _db.Entry<Conta>(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~RastreadorBoletoRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
