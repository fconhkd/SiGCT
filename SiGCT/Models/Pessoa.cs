using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    public class Pessoa
    {
        public virtual Int32 Id { get; set; }

        [Required, MaxLength(25)]
        public virtual String Nome { get; set; }

        public virtual CentroCusto CentroCusto { get; set; }
    }
}