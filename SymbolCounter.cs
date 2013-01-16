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
        public override int Count(string Text)
        {
            Regex rgx = new Regex(@"\r\n", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Text = rgx.Replace(Text, "");

            _value = Text.Length;

            return Value;
        }
    }
}
