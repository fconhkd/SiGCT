using NHibernate.Helper.Generics;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SiGCT.Models
{
    public class TipoCobranca : GenericEntity<long>
    {

        [Required, MaxLength(20)]
        public virtual String Descricao { get; set; }

        public virtual IList<Cobranca> Cobrancas { get; set; }
    }
}