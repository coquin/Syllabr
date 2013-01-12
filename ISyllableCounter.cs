using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syllabr
{
    interface ISyllableCounter
    {
        // Считает число слогов в строке
        int count(string text);
    }
}
