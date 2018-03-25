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
    public class AjusteBusiness : GenericBusiness<long, Ajuste, AjusteDAO>
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ajuste"></param>
        /// <returns></returns>
        internal Ajuste Parse(string[] array)
        {
            var ajuste = new Ajuste();
            //ajuste.

            return ajuste;
        }
    }
}
