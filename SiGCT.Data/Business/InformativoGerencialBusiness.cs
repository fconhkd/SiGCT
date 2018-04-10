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
    /// Centraliza as regras de negócio de <see cref="InformativoGerencial"/>
    /// </summary>
    public class InformativoGerencialBusiness : GenericBusiness<long, InformativoGerencial, InformativoGerencialDAO>
    {

        /// <summary>
        /// Converter um array/linha em um <see cref="InformativoGerencial"/>
        /// </summary>
        /// <param name="array"></param>
        /// <param name="conta"></param>
        /// <returns></returns>
        internal InformativoGerencial Parse(string[] array, Conta conta)
        {
            var info = new InformativoGerencial();
            info.Sequencial = int.Parse(array[1]);
            info.Conta = conta;
            info.Recurso = new RecursoBusiness().SaveAndReturn(array[5].Substring(0, 2), array[6]);
            info.Categoria = new CategoriaBusiness().SaveAndReturn(array[8]);
            info.TextoInformativo = array[9];
            info.Valor = decimal.Parse(string.Concat(array[10], array[11]));
            info.Filler = Tools.IsNullOrEmpty(array[12]) ? null : array[12];
            info.Obs = Tools.IsNullOrEmpty(array[13]) ? null : array[13];

            return info;
        }
    }
}
