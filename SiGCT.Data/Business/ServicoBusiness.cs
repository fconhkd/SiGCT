using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Helper.Generics;
using SiGCT.Data.DAO;
using SiGCT.Models;

namespace SiGCT.Data.Business
{
    public class ServicoBusiness : GenericBusiness<long, Servico, ServicoDAO>
    {
        internal Servico Parse(string[] array)
        {
            var servico = new Servico();
            servico.Sequencial = int.Parse(array[1]);
            servico.Recurso = new RecursoBusiness().GetByNumero(array[5]);


            return servico;
        }
    }
}
