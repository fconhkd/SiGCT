using System;
using System.Collections.Generic;

namespace SiGCT.Models
{
    public class CategoriaChamada
    {
        public virtual Int32 Codigo { get; set; }

        public virtual String Sigla { get; set; }

        public virtual String Descricao { get; set; }

        public virtual IList<Chamada> Chamadas { get; set; }
    }
}