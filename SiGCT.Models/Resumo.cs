using NHibernate.Helper.Generics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiGCT.Models
{
    /// <summary>
    /// Somatório dos valores por recurso
    /// Tipo 10
    /// </summary>
    public class Resumo : GenericEntity<long>
    {

        /// <summary>
        /// Armazena o codigo sequencial no arquivo lido
        /// </summary>
        [Required]
        public virtual Int32 Sequencial { get; set; }

        /// <summary>
        /// Conta vinculado a este resumo
        /// </summary>
        public virtual Conta Conta { get; set; }

        /// <summary>
        /// Recurso vinculado a este resumo
        /// </summary>
        public virtual Recurso Recurso { get; set; }

        /// <summary>
        /// Total de registros tipo "30" para o recurso
        /// </summary>
        public virtual Int32 QuantidaChamadas { get; set; }

        /// <summary>
        /// Somatório dos valores dos registros tipo "30" para o recurso. Valor sempre positivo.
        /// </summary>
        public virtual decimal ValorChamadas { get; set; }

        /// <summary>
        /// Total de registros tipo "40" para o recurso
        /// </summary>
        public virtual Int32 QuantidadeServico { get; set; }

        /// <summary>
        /// Somatório dos valores dos registros tipo "40" para o recurso. Valor sempre positivo.
        /// </summary>
        public virtual decimal ValorServicos { get; set; }

        /// <summary>
        /// Somatório dos valores de todos os impostos incidentes, inclusive impostos federais.
        /// Valor sempre positivo.
        /// </summary>
        public virtual decimal ValorImpostos { get; set; }

        /// <summary>
        /// Valor sempre positivo
        /// </summary>
        public virtual decimal ValorTotal { get; set; }

        /// <summary>
        /// Identifica o degrau tarifário conforme classificação da ANATEL
        /// Obrigatório para recursos do tipo LPCD
        /// </summary>
        public virtual Int32 Degrau { get; set; }

        /// <summary>
        /// Obrigatório para recursos do tipo LPCD
        /// </summary>
        public virtual String Velocidade { get; set; }

        /// <summary>
        /// Obrigatório para recursos do tipo LPCD
        /// </summary>
        public virtual String UnVelocidade { get; set; }

        public virtual DateTime DataVencimento { get; set; }

        [MaxLength(15)]
        public virtual String Filler { get; set; }

        /// <summary>
        /// Cmapo livre para a Operadora
        /// </summary>
        [MaxLength(25)]
        public virtual String Obs { get; set; }
    }
}