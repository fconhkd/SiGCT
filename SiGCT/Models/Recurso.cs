using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Recurso
    {

        public virtual String Id { get; set; }

        [Required]
        public virtual CNL CNL { get; set; }

        [MaxLength(16)]
        public virtual String Numero { get; set; }

        public virtual Int32 Modalidade { get; set; }

        public virtual DateTime DataAtivacao { get; set; }

        public virtual DateTime Datadesativacao { get; set; }

        public virtual IList<EnderecosRecurso> Enderecos { get; set; }
    }
}