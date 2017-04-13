using System.ComponentModel;

namespace SiGCT.Models
{
    public enum TipoNfEnum
    {
        [Description("Nota-Fiscal Propria")]
        Propria = 1,

        [Description("Nota-Fiscal de Terceiros")]
        Terceiros = 2
    }
}