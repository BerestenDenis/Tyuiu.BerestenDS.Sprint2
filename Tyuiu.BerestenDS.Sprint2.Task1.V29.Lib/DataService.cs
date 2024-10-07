using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BerestenDS.Sprint2.Task1.V29.Lib
{
    public class DataService : ISprint2Task1V29
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (c<d);
            res[1] = (a < b+5) & (d<=c);
            res[2] = (a < b + 6) || (d > c);
            res[3] =(a < b) && (c > d);
            res[4] = !res[3];
            res[5] = (a > b) ^ (c<d);
            return res;
        }
    }
}
