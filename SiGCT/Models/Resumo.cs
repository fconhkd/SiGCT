using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiGCT.Models
{
    /// <summary>
    /// Somatório dos valores por recurso
    /// </summary>
    public class Resumo
    {
        public virtual Int64 Id { get; set; }

        [Required, MaxLength(12)]
        public virtual Int64 Sequencial { get; set; }

        //[Required, StringLength(25)]
        //public virtual String IdContaUnica { get; set; }

        //[Required]
        //public virtual DateTime DataEmissao { get; set; }

        public virtual Header Header { get; set; }

        [Required]
        public virtual Int64 MesReferencia { get; set; }

        public virtual Recurso Recurso { get; set; }

        public virtual Int32 QuantidaChamadas { get; set; }

        public virtual long ValorChamadas { get; set; }

        public virtual Int32 QuantidadeServico { get; set; }

        public virtual long ValorServicos { get; set; }

        public virtual long ValorImpostos { get; set; }

        public virtual long ValorTotal { get; set; }

        public virtual Int32 Degrau { get; set; }

        public virtual String Velocidade { get; set; }

        public virtual String UnVelocidade { get; set; }

        public virtual DateTime DataVencimento { get; set; }

        [MaxLength(15)]
        public virtual String Filler { get; set; }

        [MaxLength(25)]
        public virtual String Obs { get; set; }
    }
}