using NHibernate.Helper.Generics;
using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    public class Pessoa : GenericEntity<long>
    {

        [Required, MaxLength(25)]
        public virtual String Nome { get; set; }

        public virtual CentroCusto CentroCusto { get; set; }
    }
}