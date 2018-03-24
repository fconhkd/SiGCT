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
    /// 
    /// </summary>
    public class TipoCobrancaBusiness : GenericBusiness<long, TipoCobranca, TipoCobrancaDAO>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descricao"></param>
        /// <returns></returns>
        internal TipoCobranca SaveAndReturn(string id, string descricao)
        {
            var tc = GetById(long.Parse(id));
            if (tc == null)
            {
                tc = new TipoCobranca()
                {
                    Id = long.Parse(id),
                    Descricao = descricao,
                };
                Save(tc);
            }
            return tc;
        }
    }
}
