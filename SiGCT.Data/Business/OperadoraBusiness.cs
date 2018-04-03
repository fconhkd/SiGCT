using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Helper.Generics;
using SiGCT.Data.DAO;
using SiGCT.Models;
using SiGCT.Utils;

namespace SiGCT.Data.Business
{
    /// <summary>
    /// Concentra as regras de negocio de Operadora
    /// </summary>
    public class OperadoraBusiness : GenericBusiness<string, Operadora, OperadoraDAO>
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        internal Operadora SaveAndReturn(string id, string nome = null, string cnpj = null, string uf = null)
        {
            if (Tools.IsNullOrEmpty(id)) return null;

            var op = GetById(id);

            if (op == null)
            {
                op = new Operadora()
                {
                    Id = id,
                    Nome = nome,
                    CNPJ = cnpj,
                    UF = uf
                };
            }

            return SaveAndReturn(op);
        }
    }
}
