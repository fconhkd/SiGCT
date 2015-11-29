using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Runtime.Remoting.Messaging;
using System.Web;
using NHibernate.Envers.Configuration.Attributes;

namespace SiGCT.Models.DAO
{
    public class NHibernateSessionManager
    {
        private static ISessionFactory _sessionFactory = null;
        //private static ISession _session = null;
        private const string TRANSACTION_KEY = "CONTEXT_TRANSACTION";
        private const string SESSION_KEY = "CONTEXT_SESSION";

        /// <summary>
        /// Retorna o SessionFactory do NHibernate implementado com o padrão "Singleton"
        /// </summary>
        /// <returns>ISessionFactory</returns>
        public static ISessionFactory GetSessionFactory()
        {
            InitializeSessionFactory();
            return _sessionFactory;
        }

        /// <summary>
        /// Retorna uma nova Session para ser usado na aplicação
        /// </summary>
        /// <returns>ISession</returns>
        public static ISession OpenSession()
        {
            return GetSessionFactory().OpenSession();
        }

        /// <summary>
        /// Session corespondente a requisição implementação do padrão "Open Session in View"
        /// </summary>
        public static ISession Session
        {
            get
            {
                if (IsInWebContext())
                {
                    return (ISession)HttpContext.Current.Items[SESSION_KEY];
                }
                else
                {
                    return (ISession)CallContext.GetData(SESSION_KEY);
                }
            }
            set
            {
                if (IsInWebContext())
                {
                    HttpContext.Current.Items[SESSION_KEY] = value;
                }
                else
                {
                    CallContext.SetData(SESSION_KEY, value);
                }
            }
        }

        /// <summary>
        /// Verifica se está no contexto Web
        /// </summary>
        /// <returns></returns>
        private static bool IsInWebContext()
        {
            return HttpContext.Current != null;
        }

        /// <summary>
        /// Inicializa a Session Factory do nHibernate
        /// </summary>
        public static void InitializeSessionFactory()
        {
            if (_sessionFactory == null)
            {
                var configuration = new Configuration().Configure();
                _sessionFactory = configuration.BuildSessionFactory();
            }
        }

        /// <summary>
        /// Finaliza a SessionFactory criada
        /// </summary>
        public static void CloseSessionFactory()
        {
            GetSessionFactory().Close();
        }

        /// <summary>
        /// Cria o Schema do Banco a partir das classes mapeadas *.hbm.xml
        /// </summary>
        public static void ExportSchema()
        {
            //cria uma nova cgf no NHibernate
            var cfg = new Configuration();
            cfg.Configure();

                cfg.IntegrateWithEnvers(new AttributeConfiguration());

            //Executando o schema export
            var schemaExport = new SchemaExport(cfg);
            schemaExport.Execute(true, true, false);
        }

        /// <summary>
        /// Cria o Schema do Banco a partir das classes mapeadas *.hbm.xml
        /// </summary>
        /// <param name="fileName">hibernate.hbm.xml</param>
        public static void ExportSchema(String fileName)
        {
            //cria uma nova cgf no NHibernate
            var cfg = new Configuration();
            cfg.Configure(fileName);

            //Executando o schema export
            var schemaExport = new SchemaExport(cfg);
            schemaExport.Execute(true, true, false);
        }
    }
}
