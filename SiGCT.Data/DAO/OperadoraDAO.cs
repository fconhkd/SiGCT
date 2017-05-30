using System;
using NHibernate.Helper.Generics;
using SiGCT.Models;

namespace SiGCT.Data.DAO
{
    public class OperadoraDAO : GenericDAO<long, Operadora>
    {
        internal Operadora GetByCodigo(string v1)
        {
            return GetByQuery($"From Operadora where Codigo = {0} ");
        }
    }
}