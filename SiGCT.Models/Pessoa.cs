using NHibernate.Helper.Generics;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SiGCT.Models
{
    public class Pessoa : GenericEntity<long>
    {

        [Required, MaxLength(25)]
        public virtual String Nome { get; set; }

        public virtual CentroCusto CentroCusto { get; set; }

        public virtual IList<Recurso> Recursos { get; set; }
    }
}