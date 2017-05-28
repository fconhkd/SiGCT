using System;
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

namespace SiGCT.Data.Business
{
    public class ContaBusiness : GenericBusiness<long, Conta, ContaDAO>
    {
        #region Fields
        /// <summary>
        /// Framework para log <seealso cref="log4net"/>
        /// </summary>
        private static log4net.ILog logger = LogManager.GetLogger(System.Reflection.Assembly.GetExecutingAssembly().GetName().ToString());
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
        public bool LerArquivoV3R0(string path)
        {
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
                                case "10": break;
                                case "20": break;
                                case "30": break;
                                case "40": break;
                                case "50": break;
                                case "60": break;
                                case "70": break;
                                case "80": break;
                                case "90": break;
                                case "99": break;
                                default: //TODO : Verifica o que fazer aqui
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
                    //return _listaBaixa;
                }
            }
            return false;
        }

        private void lerHeader(TextFieldParser file)
        {
            var headerParam = new int[] { 2,12,25,8,6,8,8,3,15,15,2,15,30,15,4,16,50,2,20,4,4,10,35,15,25,1};
            file.SetFieldWidths(headerParam);
            var header = file.ReadFields();

            Convert(header);
        }

        private Conta Convert(string[] array)
        {
            var conta = new Conta() {

            };

            return conta;
        }
        #endregion

    }
}
