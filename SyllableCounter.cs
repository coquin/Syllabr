using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syllabr
{
    // Класс SyllableCounter
    // Реализует функционал подсчёта слогов в переданной строке текста,
    // автоматически определяя язык
    class SyllableCounter : StringCounter
    {
        private SyllableCounterRUS counterRUS = new SyllableCounterRUS();
        private SyllableCounterENG counterENG = new SyllableCounterENG();
        private ISyllableCounter counter;

        public override int count(string text)
        {
            if (detectLanguage(text) == LanguageDetector.RUS)
            {
                counter = counterRUS;
            }
            else
            {
                counter = counterENG;
            }

            return counter.countSyllables(text);
        }
    }
}
