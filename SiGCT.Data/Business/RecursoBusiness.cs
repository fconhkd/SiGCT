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

        /// <summary>
        /// Pesquisa um recurso pelo numero, se não existir cadastra o mesmo e retorna
        /// </summary>
        /// <param name="cnl">CNL vinculado ao recurso</param>
        /// <param name="numero">numero do recurso</param>
        /// <param name="modalidade">modalidade do recurso</param>
        /// <param name="dataAtivacao">data de ativação do recurso</param>
        /// <param name="dataDesativacao">data da desativação</param>
        /// <returns></returns>
        internal Recurso SaveAndReturn(string cnl, string numero, int modalidade = 0, DateTime? dataAtivacao = null, DateTime? dataDesativacao = null)
        {
            var recurso = GetByNumero(numero);

            if (recurso == null)
            {
                recurso = new Recurso()
                {
                    //Id = id,
                    CNL = new CnlBusiness().SaveAndReturn(long.Parse(cnl)),
                    Numero = numero,
                    Modalidade = modalidade,
                    DataAtivacao = dataAtivacao,
                    DataDesativacao = dataDesativacao,
                };
            }
            else if (modalidade > 0 && recurso.Modalidade == 0)
            {
                recurso.Modalidade = modalidade;
            }
            else if (dataAtivacao != null && recurso.DataAtivacao == null)
            {
                recurso.DataAtivacao = dataAtivacao;
            }
            else if (dataDesativacao != null)
            {
                recurso.DataDesativacao = dataDesativacao;
            }

            return SaveAndReturn(recurso);
        }

        /// <summary>
        /// Procurar um recurso pelo seu numero
        /// </summary>
        /// <param name="numero">numero a ser pesquisado</param>
        /// <returns>objeto tipo <see cref="Recurso"/></returns>
        public Recurso GetByNumero(string numero)
        {
            //consulta realizada utilizando Linq
            return Get().Where(x => x.Numero == numero)
                        .FirstOrDefault();
        }
    }
}
