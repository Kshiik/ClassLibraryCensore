using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryCensore
{
    public class CensoreClass
    {
        /// <summary>
        /// заменяет во входной строке все неприличные слова на звездочки ***
        /// </summary>
        /// <param name="textString"></param>
        /// <returns>Возращает отфильтрованный текст, в которм есть все слова - "редиска"</returns>
        /// <exception cref="Exception"></exception>
        public static string Censore(string textString)
        {
            if (String.IsNullOrEmpty(textString))
            {
                throw new Exception();
            }

            List<string> badwords = new List<string> { "редиска" };
            string[] str = textString.Split(new char[] { });

            for (int i = 0; i < str.Length; i++)
            {
                if (badwords.Contains(str[i].ToLower()))
                {
                    str[i] = "***";
                }
            }
            string censoreText = string.Join(" ", str);

            return censoreText;
        }
    }
}
