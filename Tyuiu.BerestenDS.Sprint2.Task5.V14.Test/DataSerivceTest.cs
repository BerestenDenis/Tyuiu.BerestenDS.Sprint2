using Tyuiu.BerestenDS.Sprint2.Task5.V14.Lib;
namespace Tyuiu.BerestenDS.Sprint2.Task5.V14.Test
{

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TValidFindDayName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("�����������", ds.FindDayName(1));
            Assert.AreEqual("�������", ds.FindDayName(2));
            Assert.AreEqual("�����", ds.FindDayName(3));
            Assert.AreEqual("�������", ds.FindDayName(4));
            Assert.AreEqual("�������", ds.FindDayName(5));
            Assert.AreEqual("�������", ds.FindDayName(6));
            Assert.AreEqual("�����������", ds.FindDayName(0));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1);
            });
        }
    }
}