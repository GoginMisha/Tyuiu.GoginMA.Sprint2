using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoginMA.Sprint2.Task1.V26.Lib;

namespace Tyuiu.GoginMA.Sprint2.Task1.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Гогин М. А. | АСОиУБ-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Логические операции                                              *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #26                                                            *");
            Console.WriteLine("* Выполнил: Гогин Михаил Александрович | АСОиУБ-23-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,        *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в        *");
            Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^,                  *");
            Console.WriteLine("* последовательность операций не должна нарушаться), а также             *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую                    *");
            Console.WriteLine("* последовательность(массив): (True, True, True, False, True, False),    *");
            Console.WriteLine("*                                                                        *");
            int a = 654;
            int b = 671;
            int c = 874;
            int d = 137;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
