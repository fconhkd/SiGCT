using System;
using System.Collections.Generic;

namespace SiGCT.Models
{
    public class Categoria
    {
        public virtual Int32 Codigo { get; set; }

        public virtual String Sigla { get; set; }

        public virtual String Descricao { get; set; }

        public virtual TipoCategoriaEnum TipoCategoria { get; set; }

        public virtual IList<Chamada> Chamadas { get; set; }
        public virtual IList<Plano> Planos { get; set; }
        public virtual IList<Servico> Servicos { get; set; }
    }
}