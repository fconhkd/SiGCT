using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    /// <summary>
    /// Detalhamento dos serviços faturados
    /// </summary>
    public class Servico
    {
        public virtual Int64 Id { get; set; }

        [Required]
        public virtual Int32 Sequencial { get; set; }

        public virtual Conta Conta { get; }
        public virtual Recurso Recurso { get; }
        public virtual CNL Origem { get; set; }

        public virtual DateTime DataServico { get; set; }

        public virtual CNL Destino { get; set; }

        public virtual TipoCodigoEnum Codigo { get; set; }

        //public virtual CSP CSP { get; set; }

        public virtual String NumeroChamado { get; set; }

        public virtual String OperadoraRoaming { get; set; }

        public virtual Operadora Operadora { get; set; }

        public virtual Int32 QtdeUtilizada { get; set; }
        public virtual String Unidade { get; set; }

        public virtual DateTime HorarioServico { get; set; }

        public virtual Categoria Categoria { get; set; }

        //public virtual long AliquotaICMS { get; set; }

        public virtual long ValorComImposto { get; set; }

        public virtual long ValorSemImposto { get; set; }

        public virtual TipoNfEnum TipoNF { get; set; }

        public virtual NotaFiscal NotaFiscal { get; set; }

        public virtual Int32 Degrau { get; set; }

        [MaxLength(15)]
        public virtual String Filler { get; set; }

        [MaxLength(25)]
        public virtual String Obs { get; set; }
    }
}