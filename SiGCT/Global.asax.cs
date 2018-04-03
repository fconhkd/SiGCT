using SiGCT.Data.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SiGCT
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            //Esta linha eh responsavel por ativar o log4net
            log4net.Config.XmlConfigurator.Configure();

            //Ao inicializar a aplicação inicia o NHibernateSessionFactory da Aplicação
            NHibernate.Helper.Management.SessionManager.Instance.InitializeSessionFactory();

            new ConfigBusiness().Seed();

            new ContaBusiness().LerArquivoV3R0();
        }
    }
}
