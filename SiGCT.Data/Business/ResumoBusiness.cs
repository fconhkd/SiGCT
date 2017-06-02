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
    public class ResumoBusiness : GenericBusiness<long, Resumo, ResumoDAO>
    {
        internal Resumo Parse(string[] header)
        {
            throw new NotImplementedException();
        }
    }
}
