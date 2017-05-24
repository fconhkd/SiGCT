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

        public virtual Conta Conta { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual long ValorTotal { get; set; }

        public virtual Int32 QtdeRegistros { get; set; }

        public virtual long ValorTotalRegistro10 { get; set; }
        public virtual Int32 QtdeRegistros10 { get; set; }

        public virtual Int32 QtdeRegistros20 { get; set; }

        public virtual long ValorTotalRegistro30 { get; set; }
        public virtual Int32 QtdeRegistros30 { get; set; }

        public virtual long ValorTotalRegistro40 { get; set; }
        public virtual Int32 QtdeRegistros40 { get; set; }

        public virtual long SinalTotalRegistro50 { get; set; }
        public virtual long ValorTotalRegistro50 { get; set; }
        public virtual Int32 QtdeRegistros50 { get; set; }

        public virtual long ValorTotalRegistro60 { get; set; }
        public virtual Int32 QtdeRegistros60 { get; set; }

        public virtual long SinalTotalRegistro70 { get; set; }
        public virtual long ValorTotalRegistro70 { get; set; }
        public virtual Int32 QtdeRegistros70 { get; set; }

        public virtual long ValorTotalRegistro80 { get; set; }
        public virtual Int32 QtdeRegistros80 { get; set; }

        [MaxLength(15)]
        public virtual String Filler { get; set; }

        [MaxLength(25)]
        public virtual String Obs { get; set; }
    }
}