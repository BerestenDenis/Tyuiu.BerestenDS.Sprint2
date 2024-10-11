using Tyuiu.BerestenDS.Sprint2.Task5.V14.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор switch                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнил: Берестень Денис | ибксб-24-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Условие: Дано целое число k (1 <= k <= 365). Определить, каким днем     *");
        Console.WriteLine("* недели (понедельником, вторником, …, субботой или воскресеньем)         *");
        Console.WriteLine("* является k-й день не високосного года, в котором 1 января d-й день      *");
        Console.WriteLine("* недели (если 1 января — понедельник, то d = 1 , если вторник — d = 2,   *");
        Console.WriteLine("* …, если воскресенье — d = 7).                                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Какой день 1 января ");
        int d = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите день ");
        int k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.FindDayName(d, k));

        Console.ReadLine();
    }
}