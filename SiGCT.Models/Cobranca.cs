using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    public class Cobranca
    {
        public virtual Int32 Id { get; set; }

        public virtual TipoCobranca Tipo { get; set; }

        public virtual Banco Banco { get; set; }

        [Required, MaxLength(4)]
        public virtual String Agencia { get; set; }

        [Required, MaxLength(10)]
        public virtual String ContaCorrente { get; set; }
    }
}