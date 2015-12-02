using System.ComponentModel;

namespace SiGCT.Models
{
    public enum TipoCategoriaEnum
    {
        [Description("Categoria de Chamadas")]
        CHAMADA,

        [Description("Categoria de Serviços")]
        SERVICO,

        [Description("Categoria de Planos")]
        PLANO,

        [Description("Categoria de Descontos")]
        DESCONTO,

        [Description("Categoria de Ajustes")]
        AJUSTE,

        [Description("Categoria de Informativos")]
        INFORMATIVO
    }
}