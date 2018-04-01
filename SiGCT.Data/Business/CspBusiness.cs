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
    public class CspBusiness : GenericBusiness<long, CSP, CspDAO>
    {




        
        internal CSP SaveAndReturn(string id, string nome = null)
        {
            var csp = GetById(long.Parse(id));
            if (csp == null)
            {
                csp = new CSP()
                {
                    Id = long.Parse(id),
                    Nome = nome
                };
                Save(csp);
            }
            return csp;
        }
    }
}
