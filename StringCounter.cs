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
        protected int _value = 0;

        abstract public int Count(string Text);

        public override string ToString()
        {
            return Value.ToString();
        }

        public int Value
        {
            get
            {
                return _value;
            }
        }
    }
}
