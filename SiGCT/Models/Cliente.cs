using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    public class Cliente
    {
        public virtual Int64 Codigo { get; set; }

        [Required, MinLength(5), MaxLength(30)]
        public virtual String Nome { get; set; }

        [Required,StringLength(15)]
        public virtual String CNPJ { get; set; }


    }
}