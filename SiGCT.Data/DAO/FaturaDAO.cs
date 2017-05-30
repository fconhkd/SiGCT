using System;
using NHibernate.Helper.Generics;
using SiGCT.Models;

namespace SiGCT.Data.DAO
{
    /// <summary>
    /// Centraliza o acesso a dados do tipo <see cref="Fatura"/>
    /// </summary>
    public class FaturaDAO : GenericDAO<long, Fatura>
    {
        /// <summary>
        /// Busca uma fatura pelo seu numero
        /// </summary>
        /// <param name="v1">numero utilizado na busca</param>
        /// <returns>um objeto do tipo <see cref="Fatura"/></returns>
        internal Fatura GetByNumero(int v1)
        {
            return GetByQuery($"From Fatura F Where F.Numero = {v1}");
        }

    }
}