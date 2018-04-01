using NHibernate.Helper.Generics;
using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    /// <summary>
    /// Detalhamento dos planos faturados
    /// Tipo de registro: 60
    /// </summary>
    public class Plano : GenericEntity<long>
    {

        [Required]
        public virtual Int32 Sequencial { get; set; }

        public virtual Conta Conta { get; set; }
        public virtual Recurso Recurso { get; set; }
        
        public virtual string TipoPlano { get; set; }

        public virtual DateTime InicioCiclo { get; set; }

        public virtual DateTime FimCiclo { get; set; }

        public virtual Operadora Operadora { get; set; }

        public virtual int ConsumoMedido { get; set; }

        public virtual int ConsumoFranqueado { get; set; }

        [MaxLength(2)]
        public virtual String UnidMedida { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual Int32 Codigo { get; set; }

        public virtual String Descricao { get; set; }

        public virtual decimal ValorComImposto { get; set; }
        public virtual decimal ValorSemImposto { get; set; }

        public virtual NotaFiscal NotaFiscal { get; set; }

        [MaxLength(15)]
        public virtual String Filler { get; set; }

        [MaxLength(25)]
        public virtual String Obs { get; set; }
    }
}