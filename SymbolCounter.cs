using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syllabr
{
    // Класс SymbolCounter
    // Реализует функционал подсчёта символов в переданной строке текста
    class SymbolCounter : StringCounter
    {
        public override int count(string text)
        {
            detectLanguage(text);

            return text.Length;
        }
    }
}
