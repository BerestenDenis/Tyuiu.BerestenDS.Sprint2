using Tyuiu.BerestenDS.Spritn2.Task5.V14.Lib;
namespace Tyuiu.BerestenDS.Spritn2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDay()
        {
            DataService ds = new DataService();
            int k = 11;
            int d = 1;
            Assert.AreEqual("Четверг", ds.FindDayName(k, d));

        }
    }
}