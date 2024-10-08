using Tyuiu.BerestenDS.Sprint2.Task2.V1.Lib;
namespace Tyuiu.BerestenDS.Sprint2.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);

        }
    }
}