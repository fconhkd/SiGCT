using NHibernate.Helper.Generics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiGCT.Models
{
    /// <summary>
    /// Consolidação de valores da conta faturada
    /// </summary>
    public class Trailler : GenericEntity<long>
    {
        public virtual int Sequencial { get; set; }

        public virtual Conta Conta { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual decimal ValorTotal { get; set; }

        public virtual Int32 QtdeRegistros { get; set; }

        public virtual decimal ValorTotalRegistro10 { get; set; }
        public virtual Int32 QtdeRegistros10 { get; set; }

        public virtual Int32 QtdeRegistros20 { get; set; }

        public virtual decimal ValorTotalRegistro30 { get; set; }
        public virtual Int32 QtdeRegistros30 { get; set; }

        public virtual decimal ValorTotalRegistro40 { get; set; }
        public virtual Int32 QtdeRegistros40 { get; set; }

        public virtual string SinalTotalRegistro50 { get; set; }
        public virtual decimal ValorTotalRegistro50 { get; set; }
        public virtual Int32 QtdeRegistros50 { get; set; }

        public virtual decimal ValorTotalRegistro60 { get; set; }
        public virtual Int32 QtdeRegistros60 { get; set; }

        public virtual string SinalTotalRegistro70 { get; set; }
        public virtual decimal ValorTotalRegistro70 { get; set; }
        public virtual Int32 QtdeRegistros70 { get; set; }

        public virtual decimal ValorTotalRegistro80 { get; set; }
        public virtual Int32 QtdeRegistros80 { get; set; }

        [MaxLength(15)]
        public virtual String Filler { get; set; }

        [MaxLength(25)]
        public virtual String Obs { get; set; }
    }
}