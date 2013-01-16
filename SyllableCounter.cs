using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syllabr
{
    // Класс SyllableCounter
    // Реализует функционал подсчёта слогов в переданной строке текста
    class SyllableCounter : StringCounter
    {
        private SyllableCounterRUS counterRUS = new SyllableCounterRUS();
        private SyllableCounterENG counterENG = new SyllableCounterENG();
        private ISyllableCounter counter;

        private LanguageDetector languageDetector = new LanguageDetector();
        private string _language;

        private string detectLanguage(string text)
        {
            _language = languageDetector.detectLanguage(text);
            return _language;
        }

        public override int Count(string Text)
        {
            if (detectLanguage(Text) == LanguageDetector.RUS)
            {
                counter = counterRUS;
            }
            else
            {
                counter = counterENG;
            }

            _value = counter.CountSyllables(Text);
            return Value;
        }

        public override string ToString()
        {
            return _language + ": " + Value.ToString();
        }
    }
}
