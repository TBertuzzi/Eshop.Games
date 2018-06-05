using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Eshop.Games.Converters
{
    internal class FieldConverter
    {
        public static string FormatarDescricao(string descricao)
        {
            if (!string.IsNullOrEmpty(descricao))
            {
                var descricaoCorrigida = FormatarHTML(descricao.Split(new string[1] { "</p>" },
                                    StringSplitOptions.RemoveEmptyEntries)[0].Replace("<p style=\"margin-top: 0\">", ""));

                return descricaoCorrigida?.Replace("&quot", "").Replace("<p>", "");
            }
            else
            {

                return "";
            }

        }

        private static string FormatarHTML(string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }
    }
}
