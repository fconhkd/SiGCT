using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SiGCT.Utils
{
    public static class Tools
    {
        /// <summary>
        /// Verificar se a string é nula ou vazia
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static Boolean IsNullOrEmpty(String s)
        {
            return String.IsNullOrEmpty(s) || String.IsNullOrWhiteSpace(s);
        }

        /// <summary>
        /// Retorna um enum do tipo comparado
        /// </summary>
        /// <typeparam name="T">Tipo utilizado para pesquisar</typeparam>
        /// <param name="description">descrição para pesquisa</param>
        /// <returns>um objeto membro do objeto generico utilizado</returns>
        public static T GetValueFromDescription<T>(string description)
        {
            var type = typeof(T);
            if (!type.IsEnum) throw new InvalidOperationException();

            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(DescriptionAttribute)) as DescriptionAttribute;

                if (attribute != null)
                {
                    var x = string.Compare(attribute.Description, description, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase);

                    if (x == 0)
                        return (T)field.GetValue(null);
                    //if (attribute.Description == description)
                    //    return (T)field.GetValue(null);
                }
                else
                {
                    var x = string.Compare(field.Name, description, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase);

                    if (x == 0)
                        return (T)field.GetValue(null);
                    //if (field.Name == description)
                    //    return (T)field.GetValue(null);
                }
            }
            //throw new ArgumentException("Not found.", "description");
            return default(T);
        }
    }
}
