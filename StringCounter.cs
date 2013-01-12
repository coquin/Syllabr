using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syllabr
{
    // Класс StringCounter (абстрактный)
    // Реализует функционал подсчёта данных в заданной строке
    abstract class StringCounter : IStringCounter
    {
        private LanguageDetector languageDetector = new LanguageDetector();

        protected string detectLanguage(string text)
        {
            _language = languageDetector.detectLanguage(text);
            return _language;
        }

        protected string _language;

        public string language
        {
            get
            {
                return _language;
            }
        }

        abstract public int count(string text);
    }
}
