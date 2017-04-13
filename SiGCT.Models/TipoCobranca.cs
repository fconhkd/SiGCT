using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    public class TipoCobranca
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual Int32 Id { get; set; }

        [Required, MaxLength(20)]
        public virtual String Descricao { get; set; }
    }
}