using Tyuiu.MarkovaVO.Sprint3.Task4.V24.Lib;

namespace Tyuiu.MarkovaVO.Sprint3.Task4.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Маркова В. О | ПИНб-26-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #3                                                                   *");
            Console.WriteLine("* Тема: операция цикла continue и break в циклах                              *");
            Console.WriteLine("* Задание #4                                                                  *");
            Console.WriteLine("* Вариант #24                                                                 *");
            Console.WriteLine("* Выполнила: Маркова Варвара Олеговна | ПИНб-26-1                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение функции *");
            Console.WriteLine("* y=(sin(x)/x)+2. При х = 0 прервать цикл. Полученные значения перемножать.   *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"где x принимает значения от {startValue}  и {stopValue}" );

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************");

            Console.WriteLine("Цыфра: " + ds.Calculate(startValue, stopValue));
        }
    }
}
