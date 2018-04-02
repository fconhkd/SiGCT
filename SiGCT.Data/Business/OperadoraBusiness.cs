using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Helper.Generics;
using SiGCT.Data.DAO;
using SiGCT.Models;
using SiGCT.Utils;

namespace SiGCT.Data.Business
{
    /// <summary>
    /// Concentra as regras de negocio de Operadora
    /// </summary>
    public class OperadoraBusiness : GenericBusiness<long, Operadora, OperadoraDAO>
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        internal Operadora SaveAndReturn(string codigo, string nome = null, string cnpj = null, string uf = null)
        {
            if (Tools.IsNullOrEmpty(codigo)) return null;

            var op = GetByCodigo(codigo);

            if (op == null)
            {
                op = new Operadora()
                {
                    Codigo = codigo,
                    Nome = nome,
                    CNPJ = cnpj,
                    UF = uf
                };
            }
            else if (nome != null && op.Nome == null)
            {
                op.Nome = nome;
            }
            else if (cnpj != null && op.CNPJ == null)
            {
                op.CNPJ = cnpj;
            }
            else if (uf != null && op.UF == null)
            {
                op.UF = uf;
            }

            return SaveAndReturn(op);
        }

        /// <summary>
        /// Busca uma operadora pelo codigo
        /// </summary>
        /// <param name="v1">codigo a ser pesquisado</param>
        /// <returns>Retorna um objeto do tipo <see cref="Operadora"/></returns>
        public Operadora GetByCodigo(string v1)
        {
            return Dao.GetByCodigo(v1);
        }
    }
}
