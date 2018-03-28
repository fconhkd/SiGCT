using NHibernate.Helper.Generics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    /// <summary>
    /// Identificação geral da fatura em cobrança, conta telefonica
    /// Tipo: 00 header
    /// </summary>
    public class Conta : GenericEntity<long>
    {

        /// <summary>
        /// Identificador individual por recurso junto a concessionária
        /// </summary>
        [Required, StringLength(25)]
        public virtual String Identificador { get; set; }

        /// <summary>
        /// Data de Emissão da Fatura
        /// </summary>
        [Required]
        public virtual DateTime DataEmissao { get; set; }

        /// <summary>
        /// Mês de competencia de cobrança da fatura
        /// </summary>
        [Required, MaxLength(6)]
        public virtual Int32 MesReferencia { get; set; }

        [Required]
        public virtual DateTime DataArquivo { get; set; }

        [Required]
        public virtual DateTime Vencimento { get; set; }

        public virtual Operadora Operadora { get; set; }

        public virtual Cliente Cliente { get; set; }

        [Required, MaxLength(4)]
        public virtual String Versao { get; set; }

        public virtual Fatura Fatura { get; set; }

        public virtual Cobranca Cobranca { get; set; }

        [MaxLength(35)]
        public virtual String Fisco { get; set; }

        [MaxLength(15)]
        public virtual String Filler { get; set; }

        [MaxLength(25)]
        public virtual String Obs { get; set; }

        public virtual IList<Chamada> Chamadas { get; set; } = new List<Chamada>();
        public virtual IList<Servico> Servicos { get; set; } = new List<Servico>();
        public virtual IList<Plano> Planos { get; set; } = new List<Plano>();

        public virtual IList<Desconto> Descontos { get; set; } = new List<Desconto>();
        public virtual IList<EnderecosRecurso> EnderecosRecurso { get; set; } = new List<EnderecosRecurso>();
        public virtual IList<Resumo> Resumos { get; set; } = new List<Resumo>();
        public virtual IList<NotaFiscal> NotaFiscal { get; set; } = new List<NotaFiscal>();
        public virtual IList<InformativoGerencial> InformativosGerencial { get; set; } = new List<InformativoGerencial>();

        public virtual IList<Ajuste> Ajustes { get; set; } = new List<Ajuste>();
        public virtual IList<Trailler> Traillers { get; set; } = new List<Trailler>();

    }
}