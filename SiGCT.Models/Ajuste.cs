using NHibernate.Helper.Generics;
using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    /// <summary>
    /// Detalhamento dos ajustes financeiros de movimentos anteriores.
    /// </summary>
    public class Ajuste : GenericEntity<long>
    {
        [Required]
        public virtual Int32 Sequencial { get; set; }

        public virtual Conta Conta { get; set; }

        public virtual Recurso Recurso { get; set; }

        public virtual String Tipo { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual decimal BaseCalculo { get; set; }

        public virtual decimal Percentual { get; set; }


        public virtual decimal Valor { get; set; }

        public virtual DateTime Inicio { get; set; }

        public virtual DateTime Fim { get; set; }

        [MaxLength(15)]
        public virtual String Filler { get; set; }

        [MaxLength(25)]
        public virtual String Obs { get; set; }
    }
}