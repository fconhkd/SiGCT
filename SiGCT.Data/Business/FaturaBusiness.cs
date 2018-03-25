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
    /// Centraliza as regras de negocio da classe <see cref="Fatura"/>
    /// </summary>
    public class FaturaBusiness : GenericBusiness<long, Fatura, FaturaDAO>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        internal Fatura SaveAndReturn(string v1, string v2)
        {
            var fat = GetByNumero(int.Parse(v1));
            if (fat == null)
            {
                fat = new Fatura() {
                    Id = long.Parse(v1),
                    Numero = int.Parse(v1),
                    CodigoBarras = v2,
                };
                Save(fat);
            }
            return fat;
        }

        /// <summary>
        /// Busca uma fatura pelo seu numero
        /// </summary>
        /// <param name="v1">numero utilizado na busca</param>
        /// <returns>objeto do tipo <see cref="Fatura"/></returns>
        private Fatura GetByNumero(Int32 v1)
        {
            return Dao.GetByNumero(v1);
        }

    }
}
