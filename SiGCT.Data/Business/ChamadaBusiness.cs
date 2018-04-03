using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Centralizar as regras de negocio de <see cref="Chamada"/>
    /// </summary>
    public class ChamadaBusiness : GenericBusiness<long, Chamada, ChamadaDAO>
    {



        /// <summary>
        /// Converte um array em uma chamada
        /// </summary>
        /// <param name="array">array a ser convertido</param>
        /// <param name="conta">conta vinculada</param>
        /// <returns>um objeto <see cref="Chamada"/></returns>
        internal Chamada Parse(string[] array, Conta conta)
        {
            var chamada = new Chamada();
            chamada.Sequencial = int.Parse(array[1]);
            chamada.Conta = conta;

            chamada.Recurso = new RecursoBusiness().SaveAndReturn(array[5].Substring(0, 2), array[7]);
            chamada.Origem = new CnlBusiness().SaveAndReturn(int.Parse(array[6]));
            chamada.DataHoraLigacao = DateTime.ParseExact(string.Concat(array[8], array[22]), "yyyyMMddHHmmss", null);

            chamada.Destino = new CnlBusiness().SaveAndReturn(int.Parse(array[9]), array[10]);
            chamada.Internacional = array[12].Contains("00") ? true : false;
            if (!Tools.IsNullOrEmpty(array[13]))
            {
                chamada.CSP = new CspBusiness().SaveAndReturn(array[13], array[14]);
            }
            chamada.NumeroChamado = array[15];

            chamada.OperadoraRoaming = int.Parse(array[16]) > 0 ? int.Parse(array[16]) : (int?)null; ;
            chamada.Operadora = int.Parse(array[17]) == 0 ? null : new OperadoraBusiness().SaveAndReturn(array[17]);

            chamada.Duracao = TimeSpan.FromSeconds(int.Parse(array[18]));
            chamada.Categoria = new CategoriaBusiness().SaveAndReturn(array[19], array[20], array[21]);

            chamada.AliquotaICMS = decimal.Parse(array[23]) / 100;
            chamada.ValorComImposto = decimal.Parse(array[24]) / 100;
            chamada.ValorSemImposto = decimal.Parse(array[25]) / 10000;

            chamada.NotaFiscal = new NotaFiscalBusiness().SaveAndReturn(array[27], (TipoNfEnum)int.Parse(array[26]));
            chamada.Acobrar = array[28].Contains("2") ? true : false;

            chamada.GrupoTarifario = array[29];
            chamada.DescricaoTarifario = array[30];

            chamada.Degrau = int.Parse(array[31]);
            chamada.Filler = array[32];
            chamada.Obs = array[33];

            return chamada;
        }
    }
}
