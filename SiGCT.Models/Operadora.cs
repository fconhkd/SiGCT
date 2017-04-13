using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    public class Operadora
    {
        /// <summary>
        /// Número EOT junto a ABR Telecom
        /// </summary>
        public virtual Int32 Codigo { get; set; }

        [Required, MinLength(3), MaxLength(15)]
        public virtual String Nome { get; set; }

        [MaxLength(5)]
        public virtual String Sigla { get; set; }

        [Required, MinLength(14) ,MaxLength(15)]
        public virtual String CNPJ { get; set; }

        [Required, StringLength(2)]
        public virtual String UF { get; set; }

        [MaxLength(100)]
        public virtual String RazaoSocial { get; set; }

        public virtual IList<Chamada> Chamadas { get; set; }
        public virtual IList<Servico> Servicos { get; set; }

        public virtual Plano Plano { get; set; }
    }
}