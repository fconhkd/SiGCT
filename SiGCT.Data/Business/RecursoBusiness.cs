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
    public class RecursoBusiness : GenericBusiness<long, Recurso, RecursoDAO>
    {


        internal Recurso SaveAndReturn(long id, string cnl, string numero, int modalidade, DateTime dataAtivacao, DateTime? dataDesativacao)
        {
            var recurso = GetById(id);
            if (recurso == null)
            {
                recurso = new Recurso()
                {
                    Id = id,
                    CNL = new CnlBusiness().SaveAndReturn(long.Parse(cnl)),
                    Numero = numero,
                    Modalidade = modalidade,
                    DataAtivacao = dataAtivacao,
                    DataDesativacao = dataDesativacao,
                };
                Save(recurso);
            }
            return recurso;
        }

    }
}
