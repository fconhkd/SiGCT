using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Helper.Generics;
using SiGCT.Models;

namespace SiGCT.Data.DAO
{
    /// <summary>
    /// Centraliza o acesso a dados da classe <see cref="Cliente"/>
    /// </summary>
    public class ClienteDAO : GenericDAO<long, Cliente>
    {
        /// <summary>
        /// Busca um cliente a partir do codigo
        /// </summary>
        /// <param name="v">codigo do cliente</param>
        /// <returns>objeto <see cref="Cliente"/></returns>
        internal Cliente GetByCodigo(long v)
        {
            return GetByQuery($"From Cliente Where Codigo = {v}");
        }
    }
}