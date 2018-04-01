using NHibernate.Helper.Generics;
using System;
using System.Collections.Generic;

namespace SiGCT.Models
{
    /// <summary>
    /// Código de Seleção da Prestadora - CSP
    /// </summary>
    public class CSP : GenericEntity<long>
    {
        /// <summary>
        /// Nome utilizado para identificação
        /// </summary>
        public virtual String Nome { get; set; }


        /// <summary>
        /// Chamadas realizadas utilizando este código
        /// </summary>
        public virtual IList<Chamada> Chamadas { get; set; }
    }
}