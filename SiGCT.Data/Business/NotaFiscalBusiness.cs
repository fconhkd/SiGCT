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
    public class NotaFiscalBusiness : GenericBusiness<long, NotaFiscal, NotaFiscalDAO>
    {
        internal NotaFiscal Parse(string[] array)
        {
            throw new NotImplementedException();
        }
    }
}
