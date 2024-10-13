using Tyuiu.BerestenDS.Sprint2.Task7.V14.Lib;
namespace Tyuiu.BerestenDS.Sprint2.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}