using NHibernate.Helper.Generics;
using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CentroCusto : GenericEntity<long>
    {
        
        /// <summary>
        /// Sigla do centro de cruso
        /// </summary>
        [Required, MaxLength(3)]
        public virtual String Sigla { get; set; }

        /// <summary>
        /// Descrição do centro de custo
        /// </summary>
        [MaxLength(100)]
        public virtual String Descricao { get; set; }
    }
}