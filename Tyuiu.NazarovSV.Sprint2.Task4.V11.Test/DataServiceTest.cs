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
            double x = 9;
            double y = 4;
            double next = 92.205;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(next, res);
        }
    }
}
