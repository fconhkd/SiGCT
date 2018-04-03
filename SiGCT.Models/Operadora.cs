using NHibernate.Helper.Generics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Operadora : GenericEntity<string>
    {
        [Required, MinLength(3), MaxLength(51)]
        public virtual String Nome { get; set; }

        [MaxLength(80)]
        public virtual String RazaoSocial { get; set; }

        [MaxLength(5)]
        public virtual string Tiposervico { get; set; }

        [Required, MinLength(14), MaxLength(100)]
        public virtual String CNPJ { get; set; }

        [Required, StringLength(2)]
        public virtual String UF { get; set; }

        [MaxLength(5)]
        public virtual String RN1 { get; set; }

        [MaxLength(4)]
        public virtual string SPID { get; set; }

        public virtual IList<Chamada> Chamadas { get; set; }
        public virtual IList<Servico> Servicos { get; set; }
        public virtual IList<Conta> Contas { get; set; }
        public virtual IList<NotaFiscal> NotasFiscal { get; set; }

        public virtual Plano Plano { get; set; }
    }
}