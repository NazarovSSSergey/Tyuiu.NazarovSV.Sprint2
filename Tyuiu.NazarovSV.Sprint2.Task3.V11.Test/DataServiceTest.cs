using Tyuiu.NazarovSV.Sprint2.Task3.V11.Lib;
namespace Tyuiu.NazarovSV.Sprint2.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1.33);
            Assert.AreEqual(2.041, res);
        }
    }
}
