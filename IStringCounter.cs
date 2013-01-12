using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syllabr
{
    // Интерфейс IStringCounter
    // Описывает функционал подсчёта различных данных в строке
    interface IStringCounter
    {
        // Основная функция
        int count(string text);

        // Язык последней переданной строки
        string language
        {
            get;
        }
    }
}
