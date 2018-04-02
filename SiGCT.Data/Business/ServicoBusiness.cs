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
    /// Centralizar as regras de negocio de <see cref="Servico"/> - tipo 40
    /// </summary>
    public class ServicoBusiness : GenericBusiness<long, Servico, ServicoDAO>
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        internal Servico Parse(string[] array, Conta conta)
        {
            var servico = new Servico();
            servico.Sequencial = int.Parse(array[1]);
            servico.Conta = conta;

            servico.Recurso = new RecursoBusiness().GetByNumero(array[5]);
            servico.DataServico = DateTime.ParseExact(array[8], "yyyyMMdd", null);
            servico.Codigo = array[9].Contains("00") ? TipoCodigoEnum.Internacional : TipoCodigoEnum.Nacional;
            servico.NumeroChamado = array[10];
            servico.OperadoraRoaming = int.Parse(array[11]) > 0 ? int.Parse(array[11]) : (int?)null;
            servico.Operadora = Tools.IsNullOrEmpty(array[12]) ? null : new OperadoraBusiness().SaveAndReturn(array[12]);
            servico.QtdeUtilizada = array[13].TrimStart('0');
            servico.Unidade = array[14];
            servico.HorarioServico = TimeSpan.ParseExact(array[15], "hhmmss", CultureInfo.InvariantCulture);
            servico.Categoria = new CategoriaBusiness().SaveAndReturn(array[16], array[17], array[18]);
            servico.ValorComImposto = decimal.Parse(array[19]) / 100;
            servico.ValorSemImposto = decimal.Parse(array[20]) / 100;
            servico.NotaFiscal = Tools.IsNullOrEmpty(array[22]) ? null : new NotaFiscalBusiness().SaveAndReturn(numero: array[22], tipo: (TipoNfEnum)int.Parse(array[21]));
            servico.Filler = array[23];
            servico.Obs = array[24];

            return servico;
        }
    }
}
