using Tyuiu.NazarovSV.Sprint2.Task7.V12.Lib;
namespace Tyuiu.NazarovSV.Sprint2.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedAreaValid()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;

            bool wait = false;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
