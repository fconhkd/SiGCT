using NHibernate.Helper.Generics;
using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    /// <summary>
    /// Detalhamento dos serviços faturados - tipo 40
    /// </summary>
    public class Servico : GenericEntity<long>
    {

        [Required]
        public virtual Int32 Sequencial { get; set; }

        public virtual Conta Conta { get; set; }
        public virtual Recurso Recurso { get; set; }
        public virtual CNL Origem { get; set; }

        public virtual DateTime DataHoraServico { get; set; }

        public virtual CNL Destino { get; set; }

        public virtual TipoCodigoEnum Codigo { get; set; }

        //public virtual CSP CSP { get; set; }

        public virtual String NumeroChamado { get; set; }

        public virtual int? OperadoraRoaming { get; set; }

        public virtual Operadora Operadora { get; set; }

        public virtual int? QtdeUtilizada { get; set; }
        public virtual String Unidade { get; set; }

        public virtual Categoria Categoria { get; set; }

        //public virtual long AliquotaICMS { get; set; }

        public virtual decimal ValorComImposto { get; set; }

        public virtual decimal ValorSemImposto { get; set; }

        public virtual NotaFiscal NotaFiscal { get; set; }

        public virtual Int32 Degrau { get; set; }

        [MaxLength(15)]
        public virtual String Filler { get; set; }

        [MaxLength(25)]
        public virtual String Obs { get; set; }
    }
}