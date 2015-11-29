using System;
using System.Collections.Generic;

namespace SiGCT.Models
{
    /// <summary>
    /// Código de Seleção da Prestadora - CSP
    /// </summary>
    public class CSP
    {
        public virtual Int32 Codigo { get; set; }

        public virtual String Nome { get; set; }

        public virtual IList<Chamada> Chamadas { get; set; }
    }
}