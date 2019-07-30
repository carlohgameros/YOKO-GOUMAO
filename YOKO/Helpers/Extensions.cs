using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace YOKO
{
    public static class Extensions
    {
        /// <summary>
        /// Regresa el parametro para ser insertado en en una llamda de sql.
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="parametro"></param>
        /// <returns></returns>
        public static string SqlIgual(this string query, string tabla, string parametro)
        {
            return query + tabla + " = '" + parametro + "'";
        }

        /// <summary>
        /// Returns an String list of numbers.
        /// </summary>
        /// <param name="unfiltered"></param>
        /// <returns></returns>
        public static string[] filterOnlyNumbers(this string unfiltered)
        {
            return Regex.Split(unfiltered, @"\D+");
        }
    }
}
