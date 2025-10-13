using Tyuiu.NazarovSV.Sprint2.Task4.V11.Lib;
namespace Tyuiu.NazarovSV.Sprint2.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3.11;
            double y = 3.11;
            double next = 1732.731;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(next, res);
        }
    }
}
