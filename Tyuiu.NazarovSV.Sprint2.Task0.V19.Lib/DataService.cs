using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NazarovSV.Sprint2.Task0.V19.Lib
{
    public class DataService : ISprint2Task0V19
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];

            res[0] = x + 72 == y;
            res[1] = x + 1 != y;
            res[2] = x + 6 < y;
            res[3] = x + 100 > y;
            res[4] = x + (-100) <= y;
            res[5] = x + 1000 >= y;

            return res;
        }
    }
}
