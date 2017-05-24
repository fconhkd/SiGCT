using NHibernate.Helper.Generics;
using System;
using System.Collections.Generic;

namespace SiGCT.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Categoria : GenericEntity<long>
    {
        /// <summary>
        /// Sigla da categoria
        /// </summary>
        public virtual String Sigla { get; set; }

        /// <summary>
        /// Descricao da categoria
        /// </summary>
        public virtual String Descricao { get; set; }

        /// <summary>
        /// Tipo a qual a categoria pertence
        /// </summary>
        public virtual TipoCategoriaEnum TipoCategoria { get; set; }


        public virtual IList<Chamada> Chamadas { get; set; }
        public virtual IList<Plano> Planos { get; set; }
        public virtual IList<Servico> Servicos { get; set; }
        public virtual IList<Ajuste> Ajustes { get; set; }
        public virtual IList<Desconto> Descontos { get; set; }
        public virtual IList<InformativoGerencial> InformativosGerencial { get; set; }
    }
}