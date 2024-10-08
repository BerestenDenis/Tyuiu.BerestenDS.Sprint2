using Tyuiu.BerestenDS.Sprint2.Task2.V1.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Берестень Д. С.  | ИБКСБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Берестень Денис Сергеевич  | ИБКСБ 24-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и*");
        Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области*");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение х = ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение у = ");
        int y = Convert.ToInt32(Console.ReadLine());
        DataService ds = new DataService();
        bool res = ds.CheckDotInShadedArea(x, y);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (res)
        {
            Console.WriteLine("Точка не в области");
        }
        else
        {
            Console.WriteLine("Точка в области");
        }
        Console.ReadKey();
    }
}