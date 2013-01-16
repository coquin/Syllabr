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
        public int CountSyllables(string Text)
        {
            Regex rgx = new Regex(@"[аеёиоуыэюя]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(Text);
            return matches.Count;
        }
    }
}
