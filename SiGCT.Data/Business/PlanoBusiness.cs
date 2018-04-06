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
    public class PlanoBusiness : GenericBusiness<long, Plano, PlanoDAO>
    {
        internal Plano Parse(string[] array, Conta conta)
        {
            var plano = new Plano();
            plano.Sequencial = int.Parse(array[1]);
            plano.Conta = conta;
            if (array[7].Contains("R"))
            {
                plano.Recurso = new RecursoBusiness().SaveAndReturn(array[5].Substring(0, 2), array[6]);
            }
            plano.TipoPlano = array[7];
            plano.InicioCiclo = DateTime.ParseExact(array[8], "yyyyMMdd", null);
            plano.FimCiclo = DateTime.ParseExact(array[9], "yyyyMMdd", null);
            plano.Operadora = new OperadoraBusiness().SaveAndReturn(array[10], array[11]);
            plano.ConsumoMedido = int.Parse(array[12]);
            plano.ConsumoFranqueado = int.Parse(array[13]);
            plano.UnidMedida = array[14];
            plano.Categoria = new CategoriaBusiness().SaveAndReturn(array[15], array[16], array[17]);
            plano.Codigo = int.Parse(array[18]);
            plano.Descricao = array[19];
            plano.ValorComImposto = decimal.Parse(array[20]) / 100;
            plano.ValorSemImposto = decimal.Parse(array[21]) / 10000;
            plano.NotaFiscal = new NotaFiscalBusiness().SaveAndReturn(array[23],(TipoNfEnum)int.Parse(array[22]));
            plano.Filler = array[24];
            plano.Obs = array[25];

            return plano;
        }
    }
}
