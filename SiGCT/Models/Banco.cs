using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    public class Banco
    {
        public virtual Int64 Codigo { get; set; }

        [Required, MaxLength(4)]
        public virtual String Agencia { get; set; }

        [Required, MaxLength(10)]
        public virtual String ContaCorrente { get; set; }
    }
}