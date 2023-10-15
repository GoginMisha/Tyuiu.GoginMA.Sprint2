using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoginMA.Sprint2.Task6.V8.Lib;

namespace Tyuiu.GoginMA.Sprint2.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Гогин М. А. | АСОиУБ-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Получение результата из switch                                   *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #8                                                             *");
            Console.WriteLine("* Выполнил: Гогин Михаил Александрович | АСОиУБ-23-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи        *");
            Console.WriteLine("* оператора switch, вычисляет требуемое значение и возвращает результат. *");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется двумя натуральными        *");
            Console.WriteLine("* числами: m (порядковый номер месяца) и n (число).                      *");
            Console.WriteLine("* По заданным n и m определить дату предыдущего дня (принять, что n и m  *");
            Console.WriteLine("* не характеризуют 1 января).                                            *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Введите номер месяца: ");
            int numMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число месяца: ");
            int dayMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            if (((numMonth < 1) || (numMonth > 12)) || ((numMonth == 1) && (dayMonth == 1)))
            {
                Console.WriteLine("Введено неверное значение!");
            }
            else
            {
                Console.WriteLine("Дата предыдущего дня: " + ds.FindDateOfPreviousDay(numMonth, dayMonth));
            }
            Console.ReadKey();
        }
    }
}
