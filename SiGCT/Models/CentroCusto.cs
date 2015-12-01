using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    public class CentroCusto
    {
        public virtual Int32 Id { get; set; }

        [Required, MaxLength(3)]
        public virtual String Sigla { get; set; }

        [MaxLength(100)]
        public virtual String Descricao { get; set; }
    }
}