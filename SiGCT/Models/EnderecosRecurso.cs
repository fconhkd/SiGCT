using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    /// <summary>
    /// Identificação dos endereços dos recursos cobrados na fatura
    /// </summary>
    public class EnderecosRecurso
    {
        public virtual Int64 Id { get; set; }

        /// <summary>
        /// Armazena o codigo sequencial no arquivo lido
        /// </summary>
        [Required]
        public virtual Int32 Sequencial { get; set; }

        public virtual Conta Conta { get; set; }
        public virtual Recurso Recurso { get; set; }

        public virtual CNL CNL { get; set; }
        public virtual String Nome { get; set; }
        public virtual String UF { get; set; }
        public virtual String Endereco { get; set; }
        public virtual String Numero { get; set; }
        public virtual String Complemento { get; set; }
        public virtual String Bairro { get; set; }

        public virtual TipoPontaEnum Ponta { get; set; }

        [MaxLength(15)]
        public virtual String Filler { get; set; }

        [MaxLength(25)]
        public virtual String Obs { get; set; }
    }
}