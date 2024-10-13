using Tyuiu.BerestenDS.Sprint2.Task7.V14.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Берестень Д. С.  | ИБКСБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнил: Берестень Денис Сергеевич  | ИБКСБ 24-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
        Console.WriteLine("* и вычисляет, находится ли точка с координатами X,Y в заштрихованной обл.*");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите x");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите y");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        bool res = ds.CheckDotInShadedArea(x, y);
        if (res)
        {
            Console.WriteLine("Точка в области");

        }
        else
        {
            Console.WriteLine("Точка не в области");
        }
        Console.ReadKey();
    }
}