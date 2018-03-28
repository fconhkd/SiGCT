﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Microsoft.VisualBasic.FileIO;
using NHibernate.Helper.Generics;
using SiGCT.Data.DAO;
using SiGCT.Models;
using SiGCT.Utils;

namespace SiGCT.Data.Business
{
    public class ContaBusiness : GenericBusiness<long, Conta, ContaDAO>
    {
        #region Fields
        /// <summary>
        /// Framework para log <seealso cref="log4net"/>
        /// </summary>
        private static log4net.ILog logger = LogManager.GetLogger(System.Reflection.Assembly.GetExecutingAssembly().GetName().ToString());

        private Conta _conta;
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor padrão
        /// </summary>
        public ContaBusiness() { }
        #endregion

        #region Public Methods
        /// <summary>
        /// Metodo para ler o arquivo na versão V3R0
        /// </summary>
        /// <param name="path">nome do arquivo</param>
        /// <returns></returns>
        public bool LerArquivoV3R0()
        {
            var path = @"C:\Users\fabiano.conrado\Downloads\downloadFEBRABAN\612341225_146385013_53_03_2015_FebrabanV3.txt";
            if (File.Exists(path))
            {
                using (var file = new TextFieldParser(path, Encoding.UTF8))
                {
                    file.TextFieldType = FieldType.FixedWidth;
                    while (!file.EndOfData)
                    {
                        try
                        {
                            var rowType = file.PeekChars(2);
                            switch (rowType)
                            {
                                case "00": lerHeader(file); break;
                                case "10": lerResumo(file); break;
                                case "20": lerEndereco(file); break;
                                case "30": lerChamada(file); break;
                                case "40": lerServicoMedido(file); break;
                                case "50": lerDesconto(file); break;
                                case "60": lerPlano(file); break;
                                case "70": lerAjuste(file); break;
                                case "80": lerNotaFiscal(file); break;
                                case "90": lerInformativo(file); break;
                                case "99": lerTrailler(file); break;
                                default:
                                    break;
                            }
                        }
                        catch (MalformedLineException ex)
                        {
                            logger.Error(String.Format("Erro na linha '{0}' no arquivo '{1}', a linha não está em formato valido", file.LineNumber, path), ex);
                        }
                        catch (Exception ex)
                        {
                            logger.Error(String.Format("Erro na linha '{0}' no arquivo '{1}' ", file.LineNumber, path), ex);
                        }
                    }
                }
            }
            return false;
        }

        private void lerTrailler(TextFieldParser file)
        {
            var param = new int[] { 2, 12, 25, 8, 6, 8, 15, 13, 12, 13, 9, 9, 13, 9, 13, 9, 1, 13, 9, 13, 9, 1, 13, 9, 13, 9, 58, 25, 1 };
            file.SetFieldWidths(param);
            var array = file.ReadFields();

            _conta.Traillers.Add(new TraillerBusiness().Parse(array));
        }

        private void lerInformativo(TextFieldParser file)
        {
            var param = new int[] { 2, 12, 25, 8, 6, 25, 5, 16, 3, 200, 1, 13, 8, 25, 1 };
            file.SetFieldWidths(param);
            var array = file.ReadFields();

            _conta.InformativosGerencial.Add(new InformativoGerencialBusiness().Parse(array));
        }

        private void lerNotaFiscal(TextFieldParser file)
        {
            var param = new int[] { 2, 12, 25, 8, 6, 8, 3, 15, 15, 13, 1, 12, 204, 25, 1 };
            file.SetFieldWidths(param);
            var array = file.ReadFields();

            _conta.NotaFiscal.Add(new NotaFiscalBusiness().Parse(array));
        }

        /// <summary>
        /// Detalhamento financeiros de movimentos anteriores - tipo 70
        /// </summary>
        /// <param name="file"></param>
        private void lerAjuste(TextFieldParser file)
        {
            var param = new int[] { 2, 12, 25, 8, 6, 25, 16, 1, 3, 3, 40, 13, 5, 1, 13, 8, 6, 8, 6, 123, 25, 1 };
            file.SetFieldWidths(param);
            var array = file.ReadFields();

            _conta.Ajustes.Add(new AjusteBusiness().Parse(array));
        }

        private void lerPlano(TextFieldParser file)
        {
            var param = new int[] { 2, 12, 25, 8, 6, 25, 16, 1, 8, 8, 3, 15, 12, 12, 2, 3, 3, 25, 5, 25, 13, 15, 1, 12, 67, 25, 1 };
            file.SetFieldWidths(param);
            var array = file.ReadFields();

            _conta.Planos.Add(new PlanoBusiness().Parse(array));
        }

        private void lerDesconto(TextFieldParser file)
        {
            var param = new int[] { 2, 12, 25, 8, 6, 25, 16, 1, 3, 3, 25, 13, 1, 12, 5, 1, 13, 8, 6, 8, 6, 125, 25, 1 };
            file.SetFieldWidths(param);
            var array = file.ReadFields();

            _conta.Descontos.Add(new DescontoBusiness().Parse(array));
        }

        private void lerServicoMedido(TextFieldParser file)
        {
            var param = new int[] { 2, 12, 25, 8, 6, 25, 5, 16, 8, 2, 17, 5, 3, 6, 2, 6, 3, 3, 25, 13, 15, 1, 12, 104, 25, 1 };
            file.SetFieldWidths(param);
            var array = file.ReadFields();

            using (var bser = new ServicoBusiness())
            {
                var servico = bser.Parse(array);
                _conta.Servicos.Add(servico);
                servico.Conta = _conta;
                bser.SaveOrUpdate(servico);
            }
            SaveOrUpdate(_conta);
        }

        private void lerChamada(TextFieldParser file)
        {
            var param = new int[] { 2, 12, 25, 8, 6, 25, 5, 16, 8, 5, 25, 2, 2, 2, 20, 17, 5, 3, 7, 3, 3, 25, 6, 5, 13, 15, 1, 12, 1, 1, 15, 2, 27, 25, 1 };
            file.SetFieldWidths(param);
            var array = file.ReadFields();

            _conta.Chamadas.Add(new ChamadaBusiness().Parse(array));
        }

        /// <summary>
        /// Identificação dos endereços dos recursos cobrados na fatura - Tipo 20
        /// </summary>
        /// <param name="file"></param>
        private void lerEndereco(TextFieldParser file)
        {
            var param = new int[] { 2, 12, 25, 8, 6, 25, 16, 5, 15, 2, 30, 5, 8, 10, 5, 15, 2, 30, 5, 8, 10, 5, 15, 2, 30, 5, 8, 10, 5, 25, 1 };
            file.SetFieldWidths(param);
            var array = file.ReadFields();

            using (var bend = new EnderecosRecursoBusiness())
            {
                var enderecos = new EnderecosRecursoBusiness().Parse(array);
                foreach (var i in enderecos)
                {
                    _conta.EnderecosRecurso.Add(i);
                    i.Conta = _conta;
                    bend.SaveOrUpdate(i);
                }
            }
            SaveOrUpdate(_conta);
        }
        
        /// <summary>
        /// Somatório dos valores por recurso - Tipo 10
        /// </summary>
        /// <param name="file"></param>
        private void lerResumo(TextFieldParser file)
        {
            var param = new int[] { 2, 12, 25, 8, 6, 25, 5, 16, 4, 8, 8, 9, 13, 9, 15, 13, 13, 2, 5, 4, 8, 114, 25, 1 };
            file.SetFieldWidths(param);
            var array = file.ReadFields();

            using (var bres = new ResumoBusiness())
            {
                var result = bres.Parse(array);
                result.Conta = _conta;
                var resumo = bres.SaveAndReturn(result);
                _conta.Resumos.Add(resumo);
            }

            SaveOrUpdate(_conta);
        }

        /// <summary>
        /// Identificação geral da fatura de cobrança - Tipo 00
        /// </summary>
        /// <param name="file"></param>
        /// <remarks>
        /// Apenas um por conta
        /// </remarks>
        private void lerHeader(TextFieldParser file)
        {
            var param = new int[] { 2, 12, 25, 8, 6, 8, 8, 3, 15, 15, 2, 15, 30, 15, 4, 16, 50, 2, 20, 4, 4, 10, 35, 15, 25, 1 };
            file.SetFieldWidths(param);
            var array = file.ReadFields();

            _conta = Parse(array);

            SaveOrUpdate(_conta);
        }

        /// <summary>
        /// Converter um array em uma <see cref="Conta"/>
        /// </summary>
        /// <param name="array">linha do arquivo do Tipo 00</param>
        /// <returns>Uma conta com os dados</returns>
        public Conta Parse(string[] array)
        {
            var conta = new Conta();
            conta.Identificador = array[2];
            conta.DataEmissao = DateTime.ParseExact(array[3], "yyyyMMdd", null);
            conta.DataArquivo = DateTime.ParseExact(array[5], "yyyyMMdd", null);
            conta.Vencimento = DateTime.ParseExact(array[6], "yyyyMMdd", null);
            conta.Operadora = new OperadoraBusiness().SaveAndReturn(array[7], array[8], array[9], array[10]);
            conta.Cliente = new ClienteBusiness().SaveAndReturn(array[11], array[12], array[13]);
            conta.Versao = array[14];
            conta.Fatura = new FaturaBusiness().SaveAndReturn(array[15], array[16]);

            var cobranca = new Cobranca();
            cobranca.Tipo = new TipoCobrancaBusiness().SaveAndReturn(array[17], array[18]);
            if (cobranca.Tipo.Id == 2)
            {
                cobranca.Banco = Tools.IsNullOrEmpty(array[19]) ? null : new BancoBusiness().SaveAndReturn(array[19]);
                cobranca.Agencia = array[20];
                cobranca.ContaCorrente = array[21];
            }
            conta.Cobranca = new CobrancaBusiness().SaveAndReturn(cobranca);

            conta.Fisco = array[22];
            conta.Filler = array[23];
            conta.Obs = array[24];

            return conta;
        }
        #endregion

    }
}
