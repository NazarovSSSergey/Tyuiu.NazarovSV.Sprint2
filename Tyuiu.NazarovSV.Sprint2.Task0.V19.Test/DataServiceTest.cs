using Tyuiu.NazarovSV.Sprint2.Task0.V19.Lib;
namespace Tyuiu.NazarovSV.Sprint2.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestResultsValid()
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 177;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] next = new bool[6] { true, true, true, true, true, true };
            CollectionAssert.AreEqual(next, res);
        }
    }
}
