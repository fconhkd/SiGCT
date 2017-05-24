using NHibernate.Helper.Generics;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SiGCT.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Cobranca : GenericEntity<long>
    {
        /// <summary>
        /// Tipo de cobrança
        /// </summary>
        public virtual TipoCobranca Tipo { get; set; }

        /// <summary>
        /// Banco vinculado a esta cobrança
        /// </summary>
        public virtual Banco Banco { get; set; }

        /// <summary>
        /// Agencia bancaria vinculada a esta cobrança
        /// </summary>
        [Required, MaxLength(4)]
        public virtual String Agencia { get; set; }

        /// <summary>
        /// Conta corrente vinculada a esta cobrança
        /// </summary>
        [Required, MaxLength(10)]
        public virtual String ContaCorrente { get; set; }

        public virtual IList<Conta> Contas { get; set; }
    }
}