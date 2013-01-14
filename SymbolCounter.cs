using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Syllabr
{
    // Класс SymbolCounter
    // Реализует функционал подсчёта символов в переданной строке текста
    class SymbolCounter : StringCounter
    {
        public override int count(string text)
        {
            Regex rgx = new Regex(@"\r\n", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            detectLanguage(text);
            text = rgx.Replace(text, "");

            return text.Length;
        }
    }
}
