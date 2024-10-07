using System.Runtime.InteropServices;
using Tyuiu.BerestenDS.Sprint2.Task1.V29.Lib;
    class Program
    {
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int a = 657;
        int b = 654;
        int c = 657;
        int d = 657;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);
        Console.Title = "Спринт #2 | Выполнил: Берестень Д. С.  | ИБКСБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнил: Берестень Денис Сергеевич  | ИБКСБ 24-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений                                *");
        Console.WriteLine("*также арифметических выражений,которая вернет логическ последовательность*");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(a = +a);
        Console.WriteLine(b = +b);
        Console.WriteLine(c = +c);
        Console.WriteLine(d = +d);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();
    }

    }