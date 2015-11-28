using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    public class Operadora
    {
        public virtual Int64 Codigo { get; set; }

        [Required, MinLength(3), MaxLength(15)]
        public virtual String NomeOperadora { get; set; }

        public virtual String Sigla { get; set; }

        [Required, MinLength(14) ,MaxLength(15)]
        public virtual String CNPJ { get; set; }

        [Required, StringLength(2)]
        public virtual String UF { get; set; }

        [MaxLength(100)]
        public virtual String RazaoSocial { get; set; }

        public virtual IList<Chamada> Chamadas { get; set; }
    }
}