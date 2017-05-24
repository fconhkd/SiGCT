using NHibernate.Helper.Generics;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SiGCT.Models
{
    public class Fatura : GenericEntity<long>
    {
        /// <summary>
        /// NUmero da fatura
        /// </summary>
        public virtual Int32 Numero { get; set; }

        /// <summary>
        /// Codigo de barras da fatura
        /// </summary>
        public virtual String CodigoBarras { get; set; }

        public virtual IList<Conta> Contas { get; set; }
    }
}