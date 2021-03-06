﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Syllabr
{
    class SyllableCounterENG : ISyllableCounter
    {
        public int CountSyllables(string Text)
        {
            Regex replaceRgx = new Regex(@"\by", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Regex syllabesRgx = new Regex(@"cion|tion|sion|eau|iou|ae|ai|ay|au|ee|ea|ei|eu|ey|ie|oa|oe|oi|oo|ou|oy|ue|ui|[aueioy]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Regex eAtEndRgx = new Regex(@"e\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Regex wordsRgx = new Regex(@"\b[wbmhnrs]e\b|\bthe\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            Text = replaceRgx.Replace(Text, "");

            MatchCollection syllabesMatches = syllabesRgx.Matches(Text);
            MatchCollection eAtEndMatches = eAtEndRgx.Matches(Text);
            MatchCollection wordsMatches = wordsRgx.Matches(Text);

            return syllabesMatches.Count - eAtEndMatches.Count + wordsMatches.Count;
        }
    }
}
