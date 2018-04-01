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
    /// <summary>
    /// Centraliza regras de negocio de <see cref="Categoria"/>
    /// </summary>
    public class CategoriaBusiness : GenericBusiness<long, Categoria, CategoriaDAO>
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="sigla"></param>
        /// <param name="descricao"></param>
        /// <returns></returns>
        internal Categoria SaveAndReturn(string codigo, string sigla, string descricao)
        {
            var categoria = GetById(long.Parse(codigo));
            if (categoria == null)
            {
                categoria = new Categoria()
                {
                    Id = long.Parse(codigo),
                    Sigla = sigla,
                    Descricao = descricao,
                };
                Save(categoria);
            }
            return categoria;
        }
    }
}
