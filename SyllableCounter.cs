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
    class SyllableCounter : IStringCounter
    {
        private SyllableCounterRUS counterRUS = new SyllableCounterRUS();
        private SyllableCounterENG counterENG = new SyllableCounterENG();
        private ISyllableCounter counter;

        private LanguageDetector languageDetector = new LanguageDetector();

        private string _language;

        public string language
        {
            get
            {
                return _language;
            }
        }

        public int count(string text)
        {
            _language = languageDetector.detectLanguage(text);

            if (_language == LanguageDetector.RUS)
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
