using Tyuiu.MarkovaVO.Sprint3.Task5.V25.Lib;

namespace Tyuiu.MarkovaVO.Sprint3.Task5.V25
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
            Console.WriteLine("* Задание #5                                                                  *");
            Console.WriteLine("* Вариант #25                                                                 *");
            Console.WriteLine("* Выполнила: Маркова Варвара Олеговна | ПИНб-26-1                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* 3   10                                                                      *");
            Console.WriteLine("* y=∑  ∑ (x^k+cos(k))                                                         *");
            Console.WriteLine("* i=1 k=1                                                                     *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");

            int x = 2;
            int istart = 1;
            int kstart = 1;
            int istop = 3;
            int kstop = 10;

            Console.WriteLine("x = " + x);
            Console.WriteLine("Старт шага i = " + istart);
            Console.WriteLine("Старт шага k = " + kstart);
            Console.WriteLine("Конец шага i = " + kstop);
            Console.WriteLine("Конец шага i = " + istop);

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, istart, kstart, istop, kstop));
        }
    }
}
