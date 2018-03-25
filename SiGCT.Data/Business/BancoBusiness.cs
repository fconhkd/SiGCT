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
    public class BancoBusiness : GenericBusiness<long, Banco, BancoDAO>
    {
        internal Banco SaveAndReturn(string v)
        {
            var banco = GetById(long.Parse(v));

            if (banco == null)
            {
                banco.Id = long.Parse(v);
            }
            Save(banco);

            return banco;
        }
    }
}
