using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    public class Banco
    {
        /// <summary>
        /// Codigo do banco conforme Banco Central do Brasil
        /// </summary>
        public virtual Int32 Codigo { get; set; }

        /// <summary>
        /// Nome do banco
        /// </summary>
        public virtual String Nome { get; set; }

        public virtual IList<Cobranca> Cobrancas { get; set; }
    }
}