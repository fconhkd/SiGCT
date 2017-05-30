using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Helper.Generics;
using SiGCT.Data.DAO;
using SiGCT.Models;

namespace SiGCT.Data.Business
{
    /// <summary>
    /// Centraliza as regras de negocio de cliente
    /// </summary>
    public class ClienteBusiness : GenericBusiness<long, Cliente, ClienteDAO>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        /// <returns></returns>
        internal Cliente SaveAndReturn(string v1, string v2, string v3)
        {
            var cli = GetByCodigo(v1);
            if (cli == null)
            {
                cli = new Cliente() {
                    Codigo = long.Parse(v1),
                    Nome = v2,
                    CNPJ = v3,
                };
            }
            return cli;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        private Cliente GetByCodigo(string v1)
        {
            return Dao.GetByCodigo(long.Parse(v1));
        }
    }
}
