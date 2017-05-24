using NHibernate.Helper.Generics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    /// <summary>
    /// Codigo nacional de Localidade
    /// </summary>
    public class CNL : GenericEntity<long>
    {

        [MaxLength(80)]
        public virtual String Nome { get; set; }

        [MaxLength(2)]
        public virtual String UF { get; set; }

        public virtual IList<Recurso> Recursos { get; set; }

        public virtual IList<EnderecosRecurso> Enderecos { get; set; }

        public virtual IList<Chamada> Chamadas { get; set; }

        public virtual IList<CNL> Origens { get; set; }
        public virtual IList<CNL> Destinos { get; set; }
    }
}