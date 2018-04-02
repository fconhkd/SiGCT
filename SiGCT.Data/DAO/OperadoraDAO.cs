using System;
using NHibernate.Helper.Generics;
using SiGCT.Models;

namespace SiGCT.Data.DAO
{
    public class OperadoraDAO : GenericDAO<long, Operadora>
    {




        /// <summary>
        /// Buscar pelo codigo 
        /// </summary>
        /// <param name="v1">codigo a ser consultado</param>
        /// <returns>Retorna o objeto se existir, ou NULL caso não exista</returns>
        internal Operadora GetByCodigo(string v1)
        {
            return GetByQuery($"From Operadora where Codigo = '{v1}' ");
        }
    }
}