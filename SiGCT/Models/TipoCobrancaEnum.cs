using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SiGCT.Models
{
    
    public enum TipoCobrancaEnum
    {
        [Description("Debito automático")]
        DebitoAutomatico = 01,

        [Description("Crédito em conta")]
        CreditoEmConta = 02,

        [Description("Cobrança simples")]
        CobrancaSimples = 03,

        [Description("Cobrança registrada")]
        CobrancaRegistrada = 04,

        [Description("Cartão Crédito")]
        CartaoCredito = 05,

        [Description("Outros")]
        Outros = 06
    }
}