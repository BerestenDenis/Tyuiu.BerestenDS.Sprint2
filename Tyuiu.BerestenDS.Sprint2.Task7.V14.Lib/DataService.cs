using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BerestenDS.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (x * x + (y * y) <= 1)
            {
                if (x > 0)
                {
                    res = true;
                }
                if ((y < -x) && (y > x))
                {
                    res = false;
                }
                else
                {
                    res = true;
                }
            }
            else
            {
                res = true;
            }
            return res;


        }
    }
}
