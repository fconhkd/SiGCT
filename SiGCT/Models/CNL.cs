using System;
using System.Collections.Generic;

namespace SiGCT.Models
{
    public class CNL
    {
        public virtual Int64 Id { get; set; }

        public virtual String Nome { get; set; }

        public virtual String UF { get; set; }

        public virtual IList<Recurso> Recursos { get; set; }

        public virtual IList<EnderecosRecurso> Enderecos { get; set; }

        public virtual IList<Chamada> Chamadas { get; set; }
    }
}