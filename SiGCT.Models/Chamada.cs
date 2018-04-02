using NHibernate.Helper.Generics;
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
    public class Chamada : GenericEntity<long>
    {

        [Required]
        public virtual Int32 Sequencial { get; set; }

        public virtual Conta Conta { get; set; }
        public virtual Recurso Recurso { get; set; }
        public virtual CNL Origem { get; set; }

        public virtual DateTime DataHoraLigacao { get; set; }

        public virtual CNL Destino { get; set; }

        public virtual bool Internacional { get; set; }

        public virtual CSP CSP { get; set; }

        public virtual String NumeroChamado { get; set; }

        //TODO Verificar se é possivel armazenar em operadora
        public virtual int? OperadoraRoaming { get; set; } 

        public virtual Operadora Operadora { get; set; }

        public virtual TimeSpan Duracao { get; set; }

        public virtual Categoria Categoria { get; set; }


        public virtual decimal AliquotaICMS { get; set; }

        public virtual decimal ValorComImposto { get; set; }

        public virtual decimal ValorSemImposto { get; set; }


        public virtual NotaFiscal NotaFiscal { get; set; }

        public virtual bool Acobrar { get; set; }

        public virtual String GrupoTarifario { get; set; }

        public virtual String DescricaoTarifario { get; set; }

        public virtual Int32 Degrau { get; set; }

        [MaxLength(15)]
        public virtual String Filler { get; set; }

        [MaxLength(25)]
        public virtual String Obs { get; set; }
    }
}