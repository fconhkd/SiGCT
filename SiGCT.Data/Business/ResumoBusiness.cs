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
    /// Centraliza as regras de negocio de resumo - tipo 10
    /// </summary>
    public class ResumoBusiness : GenericBusiness<long, Resumo, ResumoDAO>
    {


        /// <summary>
        /// Converte um array (linha tipo 10) em um resumo
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        internal Resumo Parse(string[] array, Conta conta)
        {
            var resumo = new Resumo();
            resumo.Sequencial = int.Parse(array[1]);
            resumo.Conta = conta;

            resumo.Recurso = new RecursoBusiness()
                                    .SaveAndReturn(
                                        //long.Parse(array[5]), // id do recurso
                                        cnl: array[6], // codigo cnl
                                        numero: array[7], // numero do recurso
                                        modalidade: int.Parse(array[8]), // id modalidade
                                        dataAtivacao:  DateTime.ParseExact(array[9], "yyyyMMdd", null)
                                        //null //DateTime.ParseExact(array[10], "yyyyMMdd", null)
                                        );
            int qtdeChamadas;
            resumo.QuantidadeChamadas = int.TryParse(array[11], out qtdeChamadas) ? qtdeChamadas : (int?)null;

            decimal valorChamadas;
            resumo.ValorChamadas = decimal.TryParse(array[12], out valorChamadas) ? valorChamadas : (decimal?)null;

            int qtdeServico;
            resumo.QuantidadeServico = int.TryParse(array[13], out qtdeServico) ? qtdeServico : (int?)null;

            decimal valorServicos;
            resumo.ValorServicos = decimal.TryParse(array[14], out valorServicos) ? valorServicos : (decimal?)null;

            decimal valorImpostos;
            resumo.ValorImpostos = decimal.TryParse(array[15], out valorImpostos) ? valorImpostos : (decimal?)null;

            decimal valorTotal;
            resumo.ValorTotal = decimal.TryParse(array[16], out valorTotal) ? valorTotal : (decimal?)null;

            resumo.Degrau = Tools.IsNullOrEmpty(array[17]) ? null : (int?)int.Parse(array[17]);
            resumo.Velocidade = Tools.IsNullOrEmpty(array[18]) ? null : array[18];
            resumo.UnVelocidade = Tools.IsNullOrEmpty(array[19]) ? null : array[19];
            resumo.DataVencimento = DateTime.ParseExact(array[20], "yyyyMMdd", null);
            resumo.Filler = Tools.IsNullOrEmpty(array[21]) ? null : array[21];
            resumo.Obs = Tools.IsNullOrEmpty(array[22]) ? null : array[22];

            return resumo;
        }
    }
}
