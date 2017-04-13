using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    /// <summary>
    /// Codigo nacional de Localidade
    /// </summary>
    public class CNL
    {
        public virtual Int64 Id { get; set; }

        [MaxLength(80)]
        public virtual String Nome { get; set; }

        [MaxLength(2)]
        public virtual String UF { get; set; }

        public virtual IList<Recurso> Recursos { get; set; }

        public virtual IList<EnderecosRecurso> Enderecos { get; set; }

        public virtual IList<Chamada> Chamadas { get; set; }
    }
}