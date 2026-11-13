using Tyuiu.MarkovaVO.Sprint3.Task1.V17.Lib;

namespace Tyuiu.MarkovaVO.Sprint3.Task1.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Маркова В. О | ПИНб-26-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #3                                                                   *");
            Console.WriteLine("* Тема: операция цикла while                                                  *");
            Console.WriteLine("* Задание #1                                                                  *");
            Console.WriteLine("* Вариант #17                                                                 *");
            Console.WriteLine("* Выполнила: Маркова Варвара Олеговна | ПИНб-26-1                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу используя цикл  while, которая вычисляет произведение    *");
            Console.WriteLine("* ряда по формуле, при х=1                                                    *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");

            int value = 1;
            int startValue = 1;
            int stopValue = 4;

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
        }
    }
}
