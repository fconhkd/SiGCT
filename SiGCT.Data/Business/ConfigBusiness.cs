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
    public class ConfigBusiness
    {
        /// <summary>
        /// Semear dados no db
        /// </summary>
        public void Seed()
        {
            InserirCategorias();
            InserirTipoCobranca();
            InserirCSP();
        }

        /// <summary>
        /// Inserir categorias no db caso nao exista
        /// </summary>
        public void InserirCategorias()
        {
            using (var catBus = new CategoriaBusiness())
            {
                if (catBus.Count() == 0)
                {
                    var listaCategoria = new List<Categoria>();
                    // ANEXO I - Chamada
                    listaCategoria.Add(new Categoria() { Id = 101, Sigla = "300", Descricao = "Chamada 0300", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 102, Sigla = "500", Descricao = "Chamada 0500", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 103, Sigla = "800", Descricao = "Chamada 0800", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 104, Sigla = "900", Descricao = "Chamada 0900", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 105, Sigla = "LDI", Descricao = "LD Internacional", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 106, Sigla = "DSL", Descricao = "Deslocamento", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 107, Sigla = "LDN", Descricao = "LD Nacional Intra Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 108, Sigla = "LDN", Descricao = "LD Nacional Inter Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 109, Sigla = "LDN", Descricao = "LD Nacional On Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 110, Sigla = "LDN", Descricao = "LD Nacional Off Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 111, Sigla = "LDR", Descricao = "LD Regional Intra Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 112, Sigla = "LDR", Descricao = "LD Regional Inter Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 113, Sigla = "LDR", Descricao = "LD Regional On Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 114, Sigla = "LDR", Descricao = "LD Regional Off Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 115, Sigla = "LOC", Descricao = "Local Intra Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 116, Sigla = "LOC", Descricao = "Local Inter Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 117, Sigla = "LOC", Descricao = "Local On Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 118, Sigla = "LOC", Descricao = "Local Off Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 119, Sigla = "TVL", Descricao = "Transporte Voz Local Intra Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 120, Sigla = "TVL", Descricao = "Transporte Voz Local Inter Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 121, Sigla = "TVL", Descricao = "Transporte Voz Local On Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 122, Sigla = "TVL", Descricao = "Transporte Voz Local Off Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 123, Sigla = "TVN", Descricao = "Transporte Voz Nacional Intra Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 124, Sigla = "TVN", Descricao = "Transporte Voz Nacional Inter Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 125, Sigla = "TVN", Descricao = "Transporte Voz Nacional On Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 126, Sigla = "TVN", Descricao = "Transporte Voz Nacional Off Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 127, Sigla = "TVR", Descricao = "Transporte Voz Regional Intra Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 128, Sigla = "TVR", Descricao = "Transporte Voz Regional Inter Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 129, Sigla = "TVR", Descricao = "Transporte Voz Regional On Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 130, Sigla = "TVR", Descricao = "Transporte Voz Regional Off Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 131, Sigla = "V1R", Descricao = "Roaming Local Intra Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 132, Sigla = "V1R", Descricao = "Roaming Local Inter Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 133, Sigla = "V1R", Descricao = "Roaming Local On Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 134, Sigla = "V1R", Descricao = "Roaming Local Off Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 135, Sigla = "V2R", Descricao = "Roaming Dentro da  Area Intra Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 136, Sigla = "V2R", Descricao = "Roaming Dentro da Area Inter Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 137, Sigla = "V2R", Descricao = "Roaming Dentro da Area On Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 138, Sigla = "V2R", Descricao = "Roaming Dentro da Area Off Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 139, Sigla = "V3R", Descricao = "Roaming Fora da  Area Intra Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 140, Sigla = "V3R", Descricao = "Roaming Fora da  Area Inter rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 141, Sigla = "V3R", Descricao = "Roaming Fora da  Area On Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 142, Sigla = "V3R", Descricao = "Roaming Fora da  Area Off Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 143, Sigla = "VC1", Descricao = "Movel Local Intra Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 144, Sigla = "VC1", Descricao = "Movel Local Inter Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 145, Sigla = "VC1", Descricao = "Movel Local On Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 146, Sigla = "VC1", Descricao = "Movel Local Off Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 147, Sigla = "VC2", Descricao = "Movel Dentro da  Area Intra Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 148, Sigla = "VC2", Descricao = "Movel Dentro da  Area Inter Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 149, Sigla = "VC2", Descricao = "Movel Dentro da  Area On Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 150, Sigla = "VC2", Descricao = "Movel Dentro da  Area Off net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 151, Sigla = "VC3", Descricao = "Movel Fora da  Area Intra Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 152, Sigla = "VC3", Descricao = "Movel Fora da  Area Inter Rede", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 153, Sigla = "VC3", Descricao = "Movel Fora da  Area On Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    listaCategoria.Add(new Categoria() { Id = 154, Sigla = "VC3", Descricao = "Movel Fora da  Area Off Net", TipoCategoria = TipoCategoriaEnum.CHAMADA });
                    //ANEXO II - Serviços
                    listaCategoria.Add(new Categoria() { Id = 201, Sigla = "ASV", Descricao = "ASSINATURA VOZ", TipoCategoria = TipoCategoriaEnum.SERVICO });
                    listaCategoria.Add(new Categoria() { Id = 202, Sigla = "ASD", Descricao = "ASSINATURA DADOS", TipoCategoria = TipoCategoriaEnum.SERVICO });
                    listaCategoria.Add(new Categoria() { Id = 203, Sigla = "SMS", Descricao = "MENSAGEM SMS", TipoCategoria = TipoCategoriaEnum.SERVICO });
                    listaCategoria.Add(new Categoria() { Id = 204, Sigla = "MMS", Descricao = "MENSAGEM MMS", TipoCategoria = TipoCategoriaEnum.SERVICO });
                    listaCategoria.Add(new Categoria() { Id = 205, Sigla = "STD", Descricao = "TRAFEGO DADOS", TipoCategoria = TipoCategoriaEnum.SERVICO });
                    listaCategoria.Add(new Categoria() { Id = 206, Sigla = "STW", Descricao = "TRAFEGO WAP", TipoCategoria = TipoCategoriaEnum.SERVICO });
                    listaCategoria.Add(new Categoria() { Id = 207, Sigla = "ADC", Descricao = "ADICIONAL CHAMADAS", TipoCategoria = TipoCategoriaEnum.SERVICO });
                    listaCategoria.Add(new Categoria() { Id = 208, Sigla = "CNX", Descricao = "CONEXAO CHAMADAS", TipoCategoria = TipoCategoriaEnum.SERVICO });
                    listaCategoria.Add(new Categoria() { Id = 209, Sigla = "MNT", Descricao = "MANUTENÇÃO DE ACESSO", TipoCategoria = TipoCategoriaEnum.SERVICO });
                    listaCategoria.Add(new Categoria() { Id = 210, Sigla = "ALG", Descricao = "ALUGUEL MENSAL", TipoCategoria = TipoCategoriaEnum.SERVICO });
                    listaCategoria.Add(new Categoria() { Id = 211, Sigla = "ALM", Descricao = "ALUGUEL MODEM", TipoCategoria = TipoCategoriaEnum.SERVICO });
                    listaCategoria.Add(new Categoria() { Id = 212, Sigla = "GER", Descricao = "GERENCIAMENTO REDES", TipoCategoria = TipoCategoriaEnum.SERVICO });
                    //ANEXO III - Plano
                    listaCategoria.Add(new Categoria() { Id = 301, Sigla = "PLV", Descricao = "PLANO VOZ", TipoCategoria = TipoCategoriaEnum.PLANO });
                    listaCategoria.Add(new Categoria() { Id = 302, Sigla = "PLD", Descricao = "PLANO DADOS", TipoCategoria = TipoCategoriaEnum.PLANO });
                    listaCategoria.Add(new Categoria() { Id = 303, Sigla = "PLR", Descricao = "PLANO RADIO", TipoCategoria = TipoCategoriaEnum.PLANO });
                    listaCategoria.Add(new Categoria() { Id = 304, Sigla = "PLM", Descricao = "PLANO MENSAGEM", TipoCategoria = TipoCategoriaEnum.PLANO });
                    //ANEXO IV - Descontos
                    listaCategoria.Add(new Categoria() { Id = 401, Sigla = "DSC", Descricao = "DESCONTO CHAMADA", TipoCategoria = TipoCategoriaEnum.DESCONTO });
                    listaCategoria.Add(new Categoria() { Id = 402, Sigla = "DSS", Descricao = "DESCONTO SERVICO", TipoCategoria = TipoCategoriaEnum.DESCONTO });
                    listaCategoria.Add(new Categoria() { Id = 403, Sigla = "DSV", Descricao = "DESCONTO VOLUME", TipoCategoria = TipoCategoriaEnum.DESCONTO });
                    listaCategoria.Add(new Categoria() { Id = 404, Sigla = "DSP", Descricao = "DESCONTO PLANO", TipoCategoria = TipoCategoriaEnum.DESCONTO });
                    //ANEXO V - Ajustes
                    listaCategoria.Add(new Categoria() { Id = 501, Sigla = "JUR", Descricao = "JUROS", TipoCategoria = TipoCategoriaEnum.AJUSTE });
                    listaCategoria.Add(new Categoria() { Id = 502, Sigla = "MUL", Descricao = "MULTA", TipoCategoria = TipoCategoriaEnum.AJUSTE });
                    listaCategoria.Add(new Categoria() { Id = 503, Sigla = "ARC", Descricao = "RECURSO CANCELADO", TipoCategoria = TipoCategoriaEnum.AJUSTE });
                    listaCategoria.Add(new Categoria() { Id = 504, Sigla = "AJU", Descricao = "AJUSTE FATURA ATUAL", TipoCategoria = TipoCategoriaEnum.AJUSTE });
                    listaCategoria.Add(new Categoria() { Id = 505, Sigla = "AJA", Descricao = "AJUSTE FATURA ANTERIOR", TipoCategoria = TipoCategoriaEnum.AJUSTE });
                    listaCategoria.Add(new Categoria() { Id = 506, Sigla = "AST", Descricao = "SUBSTITUTO TRIBUTARIO", TipoCategoria = TipoCategoriaEnum.AJUSTE });
                    //ANEXO VI - Informativos
                    listaCategoria.Add(new Categoria() { Id = 601, Sigla = "CON", Descricao = "INFORMAÇÕES DE CONTAS", TipoCategoria = TipoCategoriaEnum.INFORMATIVO });
                    listaCategoria.Add(new Categoria() { Id = 602, Sigla = "REC", Descricao = "INFORMAÇÕES DE RECURSOS", TipoCategoria = TipoCategoriaEnum.INFORMATIVO });
                    listaCategoria.Add(new Categoria() { Id = 699, Sigla = "IOT", Descricao = "INFORMAÇÕES OUTROS", TipoCategoria = TipoCategoriaEnum.INFORMATIVO });

                    catBus.Save(listaCategoria);
                }
            }
        }

        /// <summary>
        /// Inserir os tipo de cobrança no db caso não exista
        /// </summary>
        public void InserirTipoCobranca()
        {
            using (var tcobBus = new TipoCobrancaBusiness())
            {
                if (tcobBus.Count() == 0)
                {
                    var lista = new List<TipoCobranca>();
                    lista.Add(new TipoCobranca() { Id = 1, Descricao = "Debito automático" });
                    lista.Add(new TipoCobranca() { Id = 2, Descricao = "Crédito em conta" });
                    lista.Add(new TipoCobranca() { Id = 3, Descricao = "Cobrança simples" });
                    lista.Add(new TipoCobranca() { Id = 4, Descricao = "Cobrança registrada" });
                    lista.Add(new TipoCobranca() { Id = 5, Descricao = "Cartão Crédito" });
                    lista.Add(new TipoCobranca() { Id = 6, Descricao = "Outros" });

                    tcobBus.Save(lista);
                }
            }
        }

        /// <summary>
        /// Inserir codigos CSP no db caso não exista
        /// </summary>
        public void InserirCSP()
        {
            using (var csp = new CspBusiness())
            {
                if (csp.Count() == 0)
                {
                    var lista = new List<CSP>();
                    lista.Add(new CSP() { Id = 12, Nome = "CTBC TELECOM " });
                    lista.Add(new CSP() { Id = 13, Nome = "FONAR" });
                    lista.Add(new CSP() { Id = 14, Nome = "BRASIL TELECOM " });
                    lista.Add(new CSP() { Id = 15, Nome = "TELEFÔNICA" });
                    lista.Add(new CSP() { Id = 17, Nome = "TRANSIT" });
                    lista.Add(new CSP() { Id = 19, Nome = "EPSILON" });
                    lista.Add(new CSP() { Id = 21, Nome = "EMBRATEL" });
                    lista.Add(new CSP() { Id = 23, Nome = "INTELIG" });
                    lista.Add(new CSP() { Id = 25, Nome = "GLOBAL VILLAGE TELECOM" });
                    lista.Add(new CSP() { Id = 26, Nome = "IDT" });
                    lista.Add(new CSP() { Id = 28, Nome = "ALPAMAYO" });
                    lista.Add(new CSP() { Id = 29, Nome = "T-LESTE" });
                    lista.Add(new CSP() { Id = 31, Nome = "TELEMAR" });
                    lista.Add(new CSP() { Id = 34, Nome = "TELEDADOS" });
                    lista.Add(new CSP() { Id = 35, Nome = "EASYTONE" });
                    lista.Add(new CSP() { Id = 38, Nome = "VIPER" });
                    lista.Add(new CSP() { Id = 41, Nome = "TIM" });
                    lista.Add(new CSP() { Id = 42, Nome = "GT GROUP " });
                    lista.Add(new CSP() { Id = 45, Nome = "IMPSAT" });
                    lista.Add(new CSP() { Id = 47, Nome = "BT COMMUNICATIONS " });
                    lista.Add(new CSP() { Id = 48, Nome = "PLENNA" });
                    lista.Add(new CSP() { Id = 51, Nome = "51 BRASIL " });
                    lista.Add(new CSP() { Id = 52, Nome = "LINKNET" });
                    lista.Add(new CSP() { Id = 53, Nome = "OSTARA" });
                    lista.Add(new CSP() { Id = 54, Nome = "TELEBIT" });
                    lista.Add(new CSP() { Id = 58, Nome = "STELLAR" });
                    lista.Add(new CSP() { Id = 61, Nome = "NEXUS" });
                    lista.Add(new CSP() { Id = 69, Nome = "REDEVOX" });
                    lista.Add(new CSP() { Id = 71, Nome = "DOLLARPHONE" });
                    lista.Add(new CSP() { Id = 81, Nome = "SERMATEL" });
                    lista.Add(new CSP() { Id = 84, Nome = "BBT BRASIL " });
                    lista.Add(new CSP() { Id = 91, Nome = "FALKLAND" });

                    csp.Save(lista);
                }
            }
        }


    }
}
