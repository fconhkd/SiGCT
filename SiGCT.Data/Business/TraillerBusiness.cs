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
    public class TraillerBusiness : GenericBusiness<long, Trailler, TraillerDAO>
    {




        internal Trailler Parse(string[] array, Conta conta)
        {

            var trailler = new Trailler();
            trailler.Sequencial = int.Parse(array[1]);
            trailler.Conta = conta;

            decimal valorTotal = 0;
            trailler.ValorTotal = decimal.TryParse(array[7], out valorTotal) ? valorTotal / 100 : 0;
            trailler.QtdeRegistros = int.Parse(array[8]);

            decimal valor10 = 0;
            trailler.ValorTotalRegistro10 = decimal.TryParse(array[9], out valor10) ? valor10 / 100 : 0;
            trailler.QtdeRegistros10 = int.Parse(array[10]);

            trailler.QtdeRegistros20 = int.Parse(array[11]);

            decimal valor30 = 0;
            trailler.ValorTotalRegistro30 = decimal.TryParse(array[12], out valor30) ? valor30 / 100 : 0;
            trailler.QtdeRegistros30 = int.Parse(array[13]);

            decimal valor40 = 0;
            trailler.ValorTotalRegistro40 = decimal.TryParse(array[14], out valor40) ? valor40 / 100 : 0;
            trailler.QtdeRegistros40 = int.Parse(array[15]);

            decimal valor50 = 0;
            trailler.SinalTotalRegistro50 = array[16];
            trailler.ValorTotalRegistro50 = decimal.TryParse(array[17], out valor50) ? valor50 / 100 * -1 : 0;
            trailler.QtdeRegistros50 = int.Parse(array[18]);

            decimal valor60 = 0;
            trailler.ValorTotalRegistro60 = decimal.TryParse(array[19], out valor60) ? valor60 / 100 : 0;
            trailler.QtdeRegistros60 = int.Parse(array[20]);

            decimal valor70 = 0;
            trailler.SinalTotalRegistro70 = array[21];
            trailler.ValorTotalRegistro70 = decimal.TryParse(array[22], out valor70) ? valor70 : 0;
            trailler.QtdeRegistros70 = int.Parse(array[23]);

            decimal valor80 = 0;
            trailler.ValorTotalRegistro80 = decimal.TryParse(array[24], out valor80) ? valor80 / 100 : 0;
            trailler.QtdeRegistros80 = int.Parse(array[25]);

            trailler.Filler = array[26];
            trailler.Obs = array[27];

            return trailler;
        }
    }
}
