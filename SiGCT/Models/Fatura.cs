using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    public class Fatura
    {
        [Required, MaxLength(16)]
        public virtual Int64 NumeroFatura { get; set; }

        public virtual String CodigoBarras { get; set; }
    }
}