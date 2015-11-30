using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiGCT.Models
{
    public class NotaFiscal
    {
        public virtual Int32 Codigo { get; set; }

        public virtual Conta Conta { get; set; }

        public virtual DateTime Vencimento { get; set; }

        public virtual Operadora Operadora { get; set; }

        public virtual long ValorTotal { get; set; }

        public virtual TipoNfEnum Tipo { get; set; }

        public virtual String Numero { get; set; }

        [MaxLength(15)]
        public virtual String Filler { get; set; }

        [MaxLength(25)]
        public virtual String Obs { get; set; }

        public virtual IList<Chamada> Chamadas { get; set; }
        public virtual IList<Servico> Servicos { get; set; }
        public virtual IList<Desconto> Descontos { get; set; }
        public virtual IList<Plano> Planos { get; set; }

    }
}