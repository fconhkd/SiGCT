using System;
using System.ComponentModel.DataAnnotations;

namespace SiGCT.Models
{
    public class Fatura
    {
        public virtual Int32 Numero { get; set; }

        public virtual String CodigoBarras { get; set; }
    }
}