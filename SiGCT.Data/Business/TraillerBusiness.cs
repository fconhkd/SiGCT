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
    public class TraillerBusiness : GenericBusiness<long, Trailler, TraillerDAO>
    {
        internal Trailler Parse(string[] array)
        {
            throw new NotImplementedException();
        }
    }
}
