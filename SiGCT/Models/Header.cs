using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiGCT.Models
{
    /// <summary>
    /// Identificação geral da fatura em cobrança
    /// </summary>
    public class Header
    {
        public virtual Int64 Id { get; set; }

        [Required, MaxLength(12)]
        public virtual Int64 Sequencial { get; set; }

        //[Required, StringLength(25)]
        //public virtual String IdContaUnica { get; set; }

        [Required]
        public virtual DateTime DataEmissao { get; set; }

        [Required]
        public virtual Int64 MesReferencia { get; set; }

        [Required]
        public virtual DateTime DataArquivo { get; set; }

        [Required]
        public virtual DateTime DataVencimento { get; set; }

        public virtual Operadora Operadora { get; set; }

        public virtual Cliente Cliente { get; set; }

        [Required, MaxLength(4)]
        public virtual String VersaoFormato { get; set; }

        [Required, MaxLength(16)]
        public virtual Int64 NumeroFatura { get; set; }

        public virtual String CodigoBarras { get; set; }

        public virtual Cobranca Cobranca { get; set; }

        [MaxLength(35)]
        public virtual String Fisco { get; set; }

        [MaxLength(15)]
        public virtual String Filler { get; set; }

        [MaxLength(25)]
        public virtual String Obs { get; set; }

        public virtual IList<Resumo> Resumos { get; set; }
        public virtual IList<EnderecosRecurso> EnderecosRecurso { get; set; }

    }
}