using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic_14
{
    /// <summary>
    /// Задание 2. Вывести на экран целые числа из интервала от 1 до n (цикл с параметром)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n = InputIntNumber("введите значение : ");
            Func(n);
            Console.ReadLine();
        }
        static int InputIntNumber(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Func(int n)
        {
            for (int x = 0; x <= n; x++)
            {
                Console.WriteLine(x);
            }
        }
    }
}
