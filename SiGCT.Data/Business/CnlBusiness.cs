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
    public class CnlBusiness : GenericBusiness<long, CNL, CnlDAO>
    {


        internal CNL SaveAndReturn(long id)
        {
            var obj = GetById(id);
            if (obj == null)
            {
                obj = new CNL()
                {
                    Id = id,
                };
                Save(obj);
            }
            return obj;
        }
    }
}
