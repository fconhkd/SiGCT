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
    /// 
    /// </summary>
    public class AjusteBusiness : GenericBusiness<long, Ajuste, AjusteDAO>
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ajuste"></param>
        /// <returns></returns>
        internal Ajuste Parse(string[] array, Conta conta)
        {
            var ajuste = new Ajuste();
            ajuste.Sequencial = int.Parse(array[1]);
            ajuste.Conta = conta;
            if (array[7].Contains("R"))
            {
                ajuste.Recurso = new RecursoBusiness().SaveAndReturn(array[5].Substring(0, 2), array[6]);
            }
            ajuste.Tipo = array[7];
            ajuste.Categoria = new CategoriaBusiness().SaveAndReturn(array[8], array[9], array[10]);
            ajuste.BaseCalculo = decimal.Parse(array[11])/100;
            ajuste.Percentual = decimal.Parse(array[12]);
            ajuste.Sinal = array[13];
            ajuste.Valor = decimal.Parse(array[14])/100;
            ajuste.Inicio = DateTime.ParseExact(string.Concat(array[15],array[16]), "yyyyMMddhhmmss", null);
            ajuste.Fim = DateTime.ParseExact(string.Concat(array[17], array[18]), "yyyyMMddhhmmss", null);
            ajuste.Filler = array[19];
            ajuste.Obs = array[20];

            return ajuste;
        }
    }
}
