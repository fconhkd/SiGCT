using NHibernate.Helper.Generics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiGCT.Models
{
    /// <summary>
    /// Informativo Gerencial, valores não contemplados na Fatura 
    /// </summary>
    public class InformativoGerencial : GenericEntity<long>
    {
        [Required]
        public virtual Int32 Sequencial { get; set; }

        public virtual Conta Conta { get; set; }
        public virtual Recurso Recurso { get; set; }
        public virtual Categoria Categoria { get; set; }

        public virtual String TextoInformativo { get; set; }


        public virtual long Valor { get; set; }

        [MaxLength(15)]
        public virtual String Filler { get; set; }

        [MaxLength(25)]
        public virtual String Obs { get; set; }
    }
}