using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    public class TipoCobranca
    {
        public virtual Int32 Codigo { get; set; }

        [Required, MaxLength(20)]
        public virtual String Descricao { get; set; }
    }
}