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
    /// Centralizar as regras de negocio de <see cref="CNL"/>
    /// </summary>
    public class CnlBusiness : GenericBusiness<long, CNL, CnlDAO>
    {


        /// <summary>
        /// Verifica se o ID existe, caso não cria o mesmo e retorna
        /// </summary>
        /// <param name="id">id a ser consultado</param>
        /// <returns>retorna um objeto CNL</returns>
        internal CNL SaveAndReturn(long id, string nome = null)
        {
            var obj = GetById(id);
            if (obj == null)
            {
                obj = new CNL()
                {
                    Id = id,
                    Nome = nome,
                };
                Save(obj);
            }
            return obj;
        }
    }
}
