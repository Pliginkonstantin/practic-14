using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic_14
{
    /// <summary>
    /// Задание 3. Вывести в столбик 5 раз слово «Привет!» (циклы с условием)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            Func();
            Console.ReadLine();
        }

        static void Func()
        {
            for (int x = 1; x <= 5; x++)
            {
                Console.WriteLine("Привет!");
            }
        }
    }
}
