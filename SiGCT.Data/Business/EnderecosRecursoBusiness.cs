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
    public class EnderecosRecursoBusiness : GenericBusiness<long, EnderecosRecurso, EnderecosRecursoDAO>
    {




        /// <summary>
        /// Converter um array do tipo 20 em um objeto <see cref="EnderecosRecurso"/>
        /// </summary>
        /// <param name="array">linha do tipo 20</param>
        /// <returns></returns>
        internal IList<EnderecosRecurso> Parse(string[] array)
        {
            var lista = new List<EnderecosRecurso>();

            var a = new EnderecosRecurso();
            a.Sequencial = int.Parse(array[1]);
            a.Recurso = new RecursoBusiness().SaveAndReturn(numero: array[5], cnl: array[7]);
            a.Nome = array[8];
            a.UF = array[9];
            a.Endereco = array[10];
            a.Numero = array[11];
            a.Complemento = array[12];
            a.Bairro = array[13];

            lista.Add(a);
            
            return lista;
        }
    }
}
