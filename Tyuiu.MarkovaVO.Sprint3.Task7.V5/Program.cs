using Tyuiu.MarkovaVO.Sprint3.Task7.V5.Lib;

namespace Tyuiu.MarkovaVO.Sprint3.Task7.V5
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
            Console.WriteLine("* Задание #7                                                                  *");
            Console.WriteLine("* Вариант #5                                                                  *");
            Console.WriteLine("* Выполнила: Маркова Варвара Олеговна | ПИНб-26-1                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции F(x)=2sin(x)/  *");
            Console.WriteLine("* /(3x+1.2)+cos(x) -7x*2 на заданном диапозоне [-5;5] с шагом 1, Произвести   *");
            Console.WriteLine("* проверку деления на ноль. При делении на ноль вернуть значение 0. Значения  *");
            Console.WriteLine("* округлить до двух знаков после запятой.                                     *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Диапозон [{startValue} {stopValue}]");

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************");

            double[] res = ds.GetMassFunction(startValue, stopValue);

            foreach (double value in res)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
