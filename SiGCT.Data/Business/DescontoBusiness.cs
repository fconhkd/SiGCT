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
    public class DescontoBusiness : GenericBusiness<long, Desconto, DescontoDAO>
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="conta"></param>
        /// <returns></returns>
        internal Desconto Parse(string[] array, Conta conta)
        {
            var desconto = new Desconto();
            desconto.Sequencial = int.Parse(array[1]);
            desconto.Conta = conta;
            if (array[7].Contains("R"))
            {
                desconto.Recurso = new RecursoBusiness().SaveAndReturn(array[5].Substring(0, 2), array[6]);
            }
            desconto.TipoDesconto = array[7];
            desconto.Categoria = new CategoriaBusiness().SaveAndReturn(array[8], array[9], array[10]);
            desconto.BaseCalculo = decimal.Parse(array[11]);
            desconto.NotaFiscal = new NotaFiscalBusiness().SaveAndReturn(array[13], (TipoNfEnum)int.Parse(array[12]));
            desconto.Percentualdesconto = array[14];
            desconto.ValorDesconto = decimal.Parse(string.Concat(array[15],array[16]));
            desconto.InicioDesconto = DateTime.ParseExact(string.Concat(array[17], array[18]), "yyyyMMddhhmmss", null);
            desconto.FimDesconto = DateTime.ParseExact(string.Concat(array[19], array[20]), "yyyyMMddhhmmss", null);
            desconto.Filler = array[21];
            desconto.Obs = array[22];

            return desconto;
        }
    }
}
