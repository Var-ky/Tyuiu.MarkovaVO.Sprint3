using Tyuiu.MarkovaVO.Sprint3.Task6.V22.Lib;

namespace Tyuiu.MarkovaVO.Sprint3.Task6.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Маркова В. О | ПИНб-26-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #3                                                                   *");
            Console.WriteLine("* Тема: Вложенные циклы                                                       *");
            Console.WriteLine("* Задание #6                                                                  *");
            Console.WriteLine("* Вариант #22                                                                 *");
            Console.WriteLine("* Выполнила: Маркова Варвара Олеговна | ПИНб-26-1                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих числовому *");
            Console.WriteLine("* отрезку [19, 31] количество всех делителей.                                 *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");

            int startValue = 19;
            int stopValue = 31;

            Console.WriteLine($"Отрезок[{startValue} {stopValue}]");

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************");

            Console.WriteLine("количество делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
        }
    }
}
