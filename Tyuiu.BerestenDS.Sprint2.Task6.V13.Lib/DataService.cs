using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BerestenDS.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int nextG = g;
            int nextM = m;
            int nextN = n + 1;
            string date;

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8: 
                case 10:
                    if (n == 31 )
                    {
                        nextM = m + 1;
                        nextN = 1;
                        date = $"{g}.{nextM}.{nextN}";

                    }
                    else
                    {
                        date = $"{g}.{m}.{nextN}";
                    }
                    break;
                case 2:
                   if (n == 29)
                    {
                        nextN = 1;
                        nextM++;
                        date = $"{g}.{nextM}.{nextN}";
                    }
                   else
                    {
                        date = $"{g}.{m}.{nextN}";
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                if (n == 30)
                    {
                        nextN = 1;
                        nextM++;
                        date = $"{g}.{nextM}.{nextN}";
                    }
                else
                    {
                        date = $"{g}.{m}.{nextN}";
                    }
                    break;
                case 12:
                    if(n == 31)
                    {
                        nextG++;
                        nextM = 1;
                        nextN = 1;
                        date = $"{nextG}.{nextM}.{nextN}";
                    }
                    else
                    {
                        date = $"{g}.{m}.{nextN}";
                    }
                    break;
            default : throw new ArgumentException($"Не верное кол-во дней в году{n}");

            }
            return date ;
        }
    }
}
