using Tyuiu.MarkovaVO.Sprint3.Task3.V27.Lib;

namespace Tyuiu.MarkovaVO.Sprint3.Task3.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Маркова В. О | ПИНб-26-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #3                                                                   *");
            Console.WriteLine("* Тема: операция цикла foreach                                                *");
            Console.WriteLine("* Задание #3                                                                  *");
            Console.WriteLine("* Вариант #27                                                                 *");
            Console.WriteLine("* Выполнила: Маркова Варвара Олеговна | ПИНб-26-1                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Используя цикл foreach удалить все буквы и знаки препинания, оставить цифру *");
            Console.WriteLine("* затем преобразовать в число в строке: !bt, g567kid f!                       *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");

            string value = "!bt, g567kid f!";

            Console.WriteLine("Исходная строка: " + value);

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************");

            Console.WriteLine("Цыфра: " + ds.ConvertStringToInt(value));
        }
    }
}
