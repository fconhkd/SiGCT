using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiGCT.Models
{
    /// <summary>
    /// Detalhamento de chamadas de VOZ cobradas na fatura
    /// </summary>
    public class Chamada
    {
        public virtual Int64 Id { get; set; }

        [Required, MaxLength(12)]
        public virtual Int64 Sequencial { get; set; }

        public virtual Conta Fatura { get; set; }

        public virtual Recurso Recurso { get; set; }

        //public virtual String NumeroRecurso { get; set; }

        public virtual CNL Origem { get; set; }

        public virtual DateTime DataLigacao { get; set; }

        public virtual CNL Destino { get; set; }

        public virtual String NomeDestino { get; set; }

        public virtual String UfDestino { get; set; }

        public virtual TipoCodigoEnum Codigo { get; set; }

        public virtual CSP CSP { get; set; }

        public virtual String NumeroChamado { get; set; }

        public virtual String OperadoraRoaming { get; set; }

        public virtual Operadora Operadora { get; set; }

        public virtual Int32 Duracao { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual DateTime HorarioLigacao { get; set; }

        public virtual long AliquotaICMS { get; set; }

        public virtual long ValorComImposto { get; set; }

        public virtual long ValorSemImposto { get; set; }

        public virtual TipoNfEnum TipoNF { get; set; }

        public virtual NotaFiscal NotaFiscal { get; set; }

        public virtual TipoChamadaEnum TipoChamada { get; set; }

        public virtual String GrupoTarifario { get; set; }

        public virtual String DescricaoTarifario { get; set; }

        public virtual Int32 Degrau { get; set; }

        [MaxLength(15)]
        public virtual String Filler { get; set; }

        [MaxLength(25)]
        public virtual String Obs { get; set; }
    }
}