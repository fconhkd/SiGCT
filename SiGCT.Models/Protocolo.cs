using NHibernate.Helper.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGCT.Models
{
    public class Protocolo : GenericEntity<long>
    {
        public virtual string Numero { get; set; }


    }
}
