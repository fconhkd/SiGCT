using System.ComponentModel;

namespace SiGCT.Models
{
    public enum TipoCodigoEnum
    {
        [Description("Ligação Nacional")]
        Nacional = 0,

        [Description("Ligação Internacional")]
        Internacional = 00
    }
}