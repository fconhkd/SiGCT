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
    /// 
    /// </summary>
    public class NotaFiscalBusiness : GenericBusiness<long, NotaFiscal, NotaFiscalDAO>
    {

        public NotaFiscal SaveAndReturn(string numero, TipoNfEnum tipo)
        {
            var nf = GetById(long.Parse(numero));
            if (nf == null)
            {
                nf = new NotaFiscal()
                {
                    Id = long.Parse(numero),
                    Numero = numero,
                    Tipo = tipo,
                };
                Save(nf);
            }
            return nf;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        internal NotaFiscal Parse(string[] array, Conta conta)
        {
            var nf = GetById(long.Parse(array[11]));
            if (nf == null)
            {
                nf = new NotaFiscal();
                nf.Id = long.Parse(array[11]);
            }
            nf.Sequencial = int.Parse(array[1]);
            nf.Conta = conta;

            nf.Emissao = DateTime.ParseExact(array[3], "yyyyMMdd", null);
            nf.Vencimento = DateTime.ParseExact(array[5], "yyyyMMdd", null);

            nf.Operadora = new OperadoraBusiness().SaveAndReturn(array[6], array[7], array[8]);

            nf.ValorTotal = decimal.Parse(array[9]) / 100;
            nf.Tipo = (TipoNfEnum)int.Parse(array[10]);
            nf.Numero = array[11];

            nf.Filler = Tools.IsNullOrEmpty(array[12]) ? null : array[12];
            nf.Obs = Tools.IsNullOrEmpty(array[13]) ? null : array[13];

            return nf;
        }
    }
}
