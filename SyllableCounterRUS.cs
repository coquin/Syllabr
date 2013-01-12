using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Syllabr
{
    class SyllableCounterRUS : ISyllableCounter
    {
        public int countSyllables(string text)
        {
            Regex rgx = new Regex(@"[аеёиоуыэюя]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(text);
            return matches.Count;
        }
    }
}
