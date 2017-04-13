using System.ComponentModel;

namespace SiGCT.Models
{
    public enum TipoChamadaEnum
    {
        [Description("Tarifada na Origem")]
        Origem = 1,

        [Description("Tarifada no Destino (a cobrar)")]
        Destino = 2
    }
}