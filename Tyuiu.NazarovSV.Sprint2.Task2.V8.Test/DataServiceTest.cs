using Tyuiu.NazarovSV.Sprint2.Task2.V8.Lib;
namespace Tyuiu.NazarovSV.Sprint2.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidTestResults()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool next = false;
            Assert.AreEqual(next, res);
        }
    }
}
