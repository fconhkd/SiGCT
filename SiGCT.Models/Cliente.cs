using NHibernate.Helper.Generics;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SiGCT.Models
{
    public class Cliente : GenericEntity<long>
    {
        /// <summary>
        /// Código interno na operadora
        /// </summary>
        public virtual Int64 Codigo { get; set; }

        /// <summary>
        /// Nome definido no contrato
        /// </summary>
        [Required, MinLength(5), MaxLength(30)]
        public virtual String Nome { get; set; }

        /// <summary>
        /// CNPJ definido no contrato
        /// </summary>
        [Required, StringLength(15)]
        public virtual String CNPJ { get; set; }

        public virtual IList<Conta> Contas { get; set; }
    }
}