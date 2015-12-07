using NHibernate;
using System;
using System.Collections.Generic;

namespace SiGCT.Models.DAO
{
    public abstract class GenericDAO<T> : IGenericDAO<T>, IDisposable
    {

        private ISession _session;

        public ISession Session
        {
            get
            {
                return _session = NHibernateSessionManager.Session;
            }
        }

        /// <summary>
        /// Inicializa a transação
        /// </summary>
        private void startTransaction()
        {
            if (Session.Transaction == null || !Session.Transaction.IsActive)
            {
                Session.BeginTransaction();
            }
        }

        /// <summary>
        /// Salvar objeto genérico
        /// </summary>
        /// <param name="o"></param>
        public void save(T o)
        {
            startTransaction();
            Session.SaveOrUpdate(o);

        }
        /// <summary>
        /// Salva lista generica
        /// </summary>
        /// <param name="o"></param>
        public void save(IList<T> o)
        {
            foreach (T item in o)
            {
                save(item);
            }
        }
        /// <summary>
        /// Deleta objeto generico
        /// </summary>
        /// <param name="o"></param>
        public void delete(T o)
        {
            startTransaction();
            Session.Delete(o);
        }
        /// <summary>
        /// Deleta objeto a partir do seu id
        /// </summary>
        /// <param name="id"></param>
        public void delete(Int32 id)
        {
            startTransaction();
            delete(getById(id));
        }
        /// <summary>
        /// Atualizar objeto persistido
        /// </summary>
        /// <param name="o"></param>
        public void update(T o)
        {
            startTransaction();
            Session.Update(o);
        }
        /// <summary>
        /// Lista a
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T getById(Int32 id)
        {
            return Session.Load<T>(id);
        }
        /// <summary>
        /// Metodo Generico que lista todos os que encontrar
        /// </summary>
        /// <returns></returns>
        public IList<T> listAll()
        {
            ICriteria criteria = Session.CreateCriteria(typeof(T));
            return criteria.List<T>();
        }
        /// <summary>
        /// Metodo Generico, Recupera um unico objeto por Query
        /// </summary>
        /// <param name="query"></param>
        /// <returns>T</returns>
        public T getByQuery(String query)
        {
            T o = Session.CreateQuery(query).UniqueResult<T>();
            return o;
        }
        /// <summary>
        /// Metodo Generico lista por query
        /// </summary>
        /// <param name="query"></param>
        /// <returns>List<T></returns>
        public List<T> listByQuery(String query)
        {
            IQuery myQuery = Session.CreateQuery(query);
            List<T> list = (List<T>)myQuery.List<T>();
            return list;
        }
        /// <summary>
        /// Destruidor da classe
        /// </summary>


        public void Dispose() { }
        
    }
}
