using System.ComponentModel.Design;
using Tyuiu.BerestenDS.Sprint2.Task5.V14.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Берестень Д. С.  | ИБКСБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнил: Берестень Денис Сергеевич  | ИБКСБ 24-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Определить, каким днем недели является k-й день не високосного года.    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите день");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите первый день в году");
        int d = Convert.ToInt32(Console.ReadLine());

        string res ;

        if ((k > 365) || (k < 1) || (d > 7) || (d < 1))
        {
            res = "не верные значения";
        }
        else
        {
            res = "это день недели - " + ds.FindDayName(k, d);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(res);

        Console.ReadKey();
    }
}