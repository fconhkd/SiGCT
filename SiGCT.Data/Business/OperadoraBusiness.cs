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
        /// <param name="codigo"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        internal Operadora SaveAndReturn(string codigo, string nome = null, string cnpj = null, string uf = null)
        {
            var op = GetByCodigo(codigo);
            if (op == null)
            {
                op = new Operadora()
                {
                    Codigo = Convert.ToInt32(codigo),
                    Nome = nome,
                    CNPJ = cnpj,
                    UF = uf
                };
                Save(op);
            }
            return op;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public Operadora GetByCodigo(string v1)
        {
            return Dao.GetByCodigo(v1);
        }
    }
}
