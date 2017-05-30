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
    /// Concentra as regras de negocio de Operadora
    /// </summary>
    public class OperadoraBusiness : GenericBusiness<long, Operadora, OperadoraDAO>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        internal Operadora SaveAndReturn(string v1, string v2, string v3, string v4)
        {
            var op = GetByCodigo(v1);
            if (op == null)
            {
                op = new Operadora() {
                    Codigo = Convert.ToInt32(v1),
                    Nome = v2,
                    CNPJ = v3,
                    UF = v4
                };
            }
            return op;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        private Operadora GetByCodigo(string v1)
        {
            return Dao.GetByCodigo(v1);
        }
    }
}
