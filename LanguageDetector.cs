using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Syllabr
{
    class LanguageDetector
    {
        public const string ENG = "ENG";
        public const string RUS = "RUS";

        private Regex languageDetectionRegex = new Regex(@"[аеёиоуыэюя]", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        // Определяет язык текстового фрагмента
        // Пока по тупому ищет гласные русского языка, если находит, то считает,
        // что имеет дело с русским языком, в противном случае - с английским
        public string detectLanguage(string text)
        {
            if (languageDetectionRegex.IsMatch(text))
            {
                return RUS;
            }
            else
            {
                return ENG;
            }
        }
    }
}
