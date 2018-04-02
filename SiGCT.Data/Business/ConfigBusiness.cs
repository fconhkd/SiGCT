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
        public void InserirCategorias()
        {
            var listaCategoria = new List<Categoria>();
            // ANEXO I - Chamada
            listaCategoria.Add(new Categoria() { Id = 101, Sigla = "300", Descricao = "Chamada 0300", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 102, Sigla = "500", Descricao = "Chamada 0500", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 103, Sigla = "800", Descricao = "Chamada 0800", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 104, Sigla = "900", Descricao = "Chamada 0900", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 105, Sigla = "LDI", Descricao = "LD Internacional", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 106, Sigla = "DSL", Descricao = "Deslocamento", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 107, Sigla = "LDN", Descricao = "LD Nacional Intra Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 108, Sigla = "LDN", Descricao = "LD Nacional Inter Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 109, Sigla = "LDN", Descricao = "LD Nacional On Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 110, Sigla = "LDN", Descricao = "LD Nacional Off Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 111, Sigla = "LDR", Descricao = "LD Regional Intra Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 112, Sigla = "LDR", Descricao = "LD Regional Inter Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 113, Sigla = "LDR", Descricao = "LD Regional On Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 114, Sigla = "LDR", Descricao = "LD Regional Off Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 115, Sigla = "LOC", Descricao = "Local Intra Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 116, Sigla = "LOC", Descricao = "Local Inter Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 117, Sigla = "LOC", Descricao = "Local On Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 118, Sigla = "LOC", Descricao = "Local Off Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 119, Sigla = "TVL", Descricao = "Transporte Voz Local Intra Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 120, Sigla = "TVL", Descricao = "Transporte Voz Local Inter Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 121, Sigla = "TVL", Descricao = "Transporte Voz Local On Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 122, Sigla = "TVL", Descricao = "Transporte Voz Local Off Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 123, Sigla = "TVN", Descricao = "Transporte Voz Nacional Intra Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 124, Sigla = "TVN", Descricao = "Transporte Voz Nacional Inter Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 125, Sigla = "TVN", Descricao = "Transporte Voz Nacional On Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 126, Sigla = "TVN", Descricao = "Transporte Voz Nacional Off Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 127, Sigla = "TVR", Descricao = "Transporte Voz Regional Intra Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 128, Sigla = "TVR", Descricao = "Transporte Voz Regional Inter Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 129, Sigla = "TVR", Descricao = "Transporte Voz Regional On Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 130, Sigla = "TVR", Descricao = "Transporte Voz Regional Off Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 131, Sigla = "V1R", Descricao = "Roaming Local Intra Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 132, Sigla = "V1R", Descricao = "Roaming Local Inter Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 133, Sigla = "V1R", Descricao = "Roaming Local On Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 134, Sigla = "V1R", Descricao = "Roaming Local Off Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 135, Sigla = "V2R", Descricao = "Roaming Dentro da  Area Intra Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 136, Sigla = "V2R", Descricao = "Roaming Dentro da Area Inter Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 137, Sigla = "V2R", Descricao = "Roaming Dentro da Area On Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 138, Sigla = "V2R", Descricao = "Roaming Dentro da Area Off Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 139, Sigla = "V3R", Descricao = "Roaming Fora da  Area Intra Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 140, Sigla = "V3R", Descricao = "Roaming Fora da  Area Inter rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 141, Sigla = "V3R", Descricao = "Roaming Fora da  Area On Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 142, Sigla = "V3R", Descricao = "Roaming Fora da  Area Off Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 143, Sigla = "VC1", Descricao = "Movel Local Intra Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 144, Sigla = "VC1", Descricao = "Movel Local Inter Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 145, Sigla = "VC1", Descricao = "Movel Local On Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 146, Sigla = "VC1", Descricao = "Movel Local Off Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 147, Sigla = "VC2", Descricao = "Movel Dentro da  Area Intra Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 148, Sigla = "VC2", Descricao = "Movel Dentro da  Area Inter Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 149, Sigla = "VC2", Descricao = "Movel Dentro da  Area On Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 150, Sigla = "VC2", Descricao = "Movel Dentro da  Area Off net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 151, Sigla = "VC3", Descricao = "Movel Fora da  Area Intra Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 152, Sigla = "VC3", Descricao = "Movel Fora da  Area Inter Rede", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 153, Sigla = "VC3", Descricao = "Movel Fora da  Area On Net", TipoCategoria.CHAMADA });
            listaCategoria.Add(new Categoria() { Id = 154, Sigla = "VC3", Descricao = "Movel Fora da  Area Off Net", TipoCategoria.CHAMADA });
            //ANEXO II - Serviços
            listaCategoria.Add(new Categoria() { Id = 201, Sigla = "ASV", Descricao = "ASSINATURA VOZ", TipoCategoria.SERVICO });
            listaCategoria.Add(new Categoria() { Id = 202, Sigla = "ASD", Descricao = "ASSINATURA DADOS", TipoCategoria.SERVICO });
            listaCategoria.Add(new Categoria() { Id = 203, Sigla = "SMS", Descricao = "MENSAGEM SMS", TipoCategoria.SERVICO });
            listaCategoria.Add(new Categoria() { Id = 204, Sigla = "MMS", Descricao = "MENSAGEM MMS", TipoCategoria.SERVICO });
            listaCategoria.Add(new Categoria() { Id = 205, Sigla = "STD", Descricao = "TRAFEGO DADOS", TipoCategoria.SERVICO });
            listaCategoria.Add(new Categoria() { Id = 206, Sigla = "STW", Descricao = "TRAFEGO WAP", TipoCategoria.SERVICO });
            listaCategoria.Add(new Categoria() { Id = 207, Sigla = "ADC", Descricao = "ADICIONAL CHAMADAS", TipoCategoria.SERVICO });
            listaCategoria.Add(new Categoria() { Id = 208, Sigla = "CNX", Descricao = "CONEXAO CHAMADAS", TipoCategoria.SERVICO });
            listaCategoria.Add(new Categoria() { Id = 209, Sigla = "MNT", Descricao = "MANUTENÇÃO DE ACESSO", TipoCategoria.SERVICO });
            listaCategoria.Add(new Categoria() { Id = 210, Sigla = "ALG", Descricao = "ALUGUEL MENSAL", TipoCategoria.SERVICO });
            listaCategoria.Add(new Categoria() { Id = 211, Sigla = "ALM", Descricao = "ALUGUEL MODEM", TipoCategoria.SERVICO });
            listaCategoria.Add(new Categoria() { Id = 212, Sigla = "GER", Descricao = "GERENCIAMENTO REDES", TipoCategoria.SERVICO });
            //ANEXO III - Plano
            listaCategoria.Add(new Categoria() { Id = 301, Sigla = "PLV", Descricao = "PLANO VOZ", TipoCategoria.PLANO });
            listaCategoria.Add(new Categoria() { Id = 302, Sigla = "PLD", Descricao = "PLANO DADOS", TipoCategoria.PLANO });
            listaCategoria.Add(new Categoria() { Id = 303, Sigla = "PLR", Descricao = "PLANO RADIO", TipoCategoria.PLANO });
            listaCategoria.Add(new Categoria() { Id = 304, Sigla = "PLM", Descricao = "PLANO MENSAGEM", TipoCategoria.PLANO });
            //ANEXO IV - Descontos
            listaCategoria.Add(new Categoria() { Id = 401, Sigla = "DSC", Descricao = "DESCONTO CHAMADA", TipoCategoria.DESCONTO });
            listaCategoria.Add(new Categoria() { Id = 402, Sigla = "DSS", Descricao = "DESCONTO SERVICO", TipoCategoria.DESCONTO });
            listaCategoria.Add(new Categoria() { Id = 403, Sigla = "DSV", Descricao = "DESCONTO VOLUME", TipoCategoria.DESCONTO });
            listaCategoria.Add(new Categoria() { Id = 404, Sigla = "DSP", Descricao = "DESCONTO PLANO", TipoCategoria.DESCONTO });
            //ANEXO V - Ajustes
            listaCategoria.Add(new Categoria() { Id = 501, Sigla = "JUR", Descricao = "JUROS", TipoCategoria.AJUSTE });
            listaCategoria.Add(new Categoria() { Id = 502, Sigla = "MUL", Descricao = "MULTA", TipoCategoria.AJUSTE });
            listaCategoria.Add(new Categoria() { Id = 503, Sigla = "ARC", Descricao = "RECURSO CANCELADO", TipoCategoria.AJUSTE });
            listaCategoria.Add(new Categoria() { Id = 504, Sigla = "AJU", Descricao = "AJUSTE FATURA ATUAL", TipoCategoria.AJUSTE });
            listaCategoria.Add(new Categoria() { Id = 505, Sigla = "AJA", Descricao = "AJUSTE FATURA ANTERIOR", TipoCategoria.AJUSTE });
            listaCategoria.Add(new Categoria() { Id = 506, Sigla = "AST", Descricao = "SUBSTITUTO TRIBUTARIO", TipoCategoria.AJUSTE });
            //ANEXO VI - Informativos
            listaCategoria.Add(new Categoria() { Id = 601, Sigla = "CON", Descricao = "INFORMAÇÕES DE CONTAS", TipoCategoria.INFORMATIVO });
            listaCategoria.Add(new Categoria() { Id = 602, Sigla = "REC", Descricao = "INFORMAÇÕES DE RECURSOS", TipoCategoria.INFORMATIVO });
            listaCategoria.Add(new Categoria() { Id = 699, Sigla = "IOT", Descricao = "INFORMAÇÕES OUTROS", TipoCategoria.INFORMATIVO });

            using (var catBus = new CategoriaBusiness())
            {
                catBus.Save(listaCategoria);
            }
        }

        public void InserirTipoCobranca()
        {
            var lista = new List<TipoCobranca>();
            lista.Add(new TipoCobranca() { Id = 1, Descricao = "Debito automático" });
            lista.Add(new TipoCobranca() { Id = 2, Descricao = "Crédito em conta" });
            lista.Add(new TipoCobranca() { Id = 3, Descricao = "Cobrança simples" });
            lista.Add(new TipoCobranca() { Id = 4, Descricao = "Cobrança registrada" });
            lista.Add(new TipoCobranca() { Id = 5, Descricao = "Cartão Crédito" });
            lista.Add(new TipoCobranca() { Id = 6, Descricao = "Outros" });

            using (var tcobBus = new TipoCobrancaBusiness())
            {
                tcobBus.Save(lista);
            }
        }

        public void InserirCSP()
        {
            var lista = new List<CSP>();
            lista.Add(new CSP() { });
        }


    }
}
