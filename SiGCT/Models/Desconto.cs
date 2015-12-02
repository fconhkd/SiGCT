using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    /// <summary>
    /// Detalhamento dos descontos concedidos
    /// </summary>
    public class Desconto
    {
        public virtual Int32 Id { get; set; }

        [Required, MaxLength(12)]
        public virtual Int32 Sequencial { get; set; }

        public virtual Conta Conta { get; set; }
        public virtual Recurso Recurso { get; set; }

        public virtual TipoAssociadoEnum TipoDesconto { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual long BaseCalculo { get; set; }

        public virtual TipoNfEnum TipoNF { get; set; }

        public virtual NotaFiscal NotaFiscal { get; set; }

        public virtual long Percentualdesconto { get; set; }

        public virtual char SinalDesconto { get; set; }

        public virtual long ValorDesconto { get; set; }

        public virtual DateTime InicioDesconto { get; set; }

        public virtual DateTime FimDesconto { get; set; }

        [MaxLength(15)]
        public virtual String Filler { get; set; }

        [MaxLength(25)]
        public virtual String Obs { get; set; }
    }
}