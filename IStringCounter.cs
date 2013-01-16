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
        int Count(string Text);

        // Преобразовывает value в строку
        string ToString();

        // Хранит последний результат работы метода count
        int Value
        {
            get;
        }
    }
}
