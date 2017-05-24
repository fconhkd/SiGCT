using NHibernate.Helper.Generics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Banco : GenericEntity<long>
    {
        /// <summary>
        /// Codigo do banco conforme Banco Central do Brasil
        /// </summary>
        public virtual Int32 Codigo { get; set; }

        /// <summary>
        /// Nome do banco
        /// </summary>
        public virtual String Nome { get; set; }

        /// <summary>
        /// Cobranças vinculadas a este banco
        /// </summary>
        public virtual IList<Cobranca> Cobrancas { get; set; }
    }
}