using NHibernate.Helper.Generics;
using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    /// <summary>
    /// Detalhamento dos descontos concedidos
    /// </summary>
    public class Desconto : GenericEntity<long>
    {

        [Required, MaxLength(12)]
        public virtual Int32 Sequencial { get; set; }

        public virtual Conta Conta { get; set; }
        public virtual Recurso Recurso { get; set; }

        public virtual string TipoDesconto { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual decimal BaseCalculo { get; set; }


        public virtual NotaFiscal NotaFiscal { get; set; }

        public virtual string Percentualdesconto { get; set; }


        public virtual decimal ValorDesconto { get; set; }

        public virtual DateTime InicioDesconto { get; set; }

        public virtual DateTime FimDesconto { get; set; }


        [MaxLength(125)]
        public virtual String Filler { get; set; }

        [MaxLength(50)]
        public virtual String Obs { get; set; }
    }
}