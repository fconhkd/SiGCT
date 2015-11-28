using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    public class Cobranca
    {
        public virtual Int64 Codigo { get; set; }

        [Required, MaxLength(20)]
        public virtual String Descricao { get; set; }

        public virtual Banco Banco { get; set; }
    }
}