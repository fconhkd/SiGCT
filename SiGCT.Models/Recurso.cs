using NHibernate.Helper.Generics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Recurso : GenericEntity<long>
    {
        /// <summary>
        /// Identificador individual por recurso junto a concessionária
        /// </summary>
        public virtual String Codigo { get; set; }

        /// <summary>
        /// Código Nacional de Localidade
        /// </summary>
        [Required]
        public virtual CNL CNL { get; set; }

        /// <summary>
        /// Para recurso de VOZ composto de 10 posições, 2 para DDD e 8 para numero.
        /// Para recurso de DADOS preencher com a designação
        /// </summary>
        [MaxLength(16)]
        public virtual String Numero { get; set; }

        /// <summary>
        /// Identifica o tipo do serviço conforme classificação da ANATEL
        /// </summary>
        public virtual Int32 Modalidade { get; set; }

        public virtual DateTime DataAtivacao { get; set; }
        public virtual DateTime? DataDesativacao { get; set; }

        public virtual IList<EnderecosRecurso> Enderecos { get; set; }
        public virtual IList<Resumo> Resumos { get; set; }
        public virtual IList<Chamada> Chamadas { get; set; }
        public virtual IList<Servico> Servicos { get; set; }
        public virtual IList<Desconto> Descontos { get; set; }
        public virtual IList<Plano> Planos { get; set; }
        public virtual IList<Ajuste> Ajustes { get; set; }
        public virtual IList<InformativoGerencial> InformativosGerencial { get; set; }

        public virtual CentroCusto CentroCusto { get; set; }
        public virtual Pessoa Utilizador { get; set; }
    }
}