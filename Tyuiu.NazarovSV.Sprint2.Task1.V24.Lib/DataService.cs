using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NazarovSV.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
             DataService ds = new DataService();
            bool[] res = new bool[6];
            res[0] = (a == b) | (c < d);
            res[1] = (c != a) & (d > b);
            res[2] = (b >= a) || (d < c);
            res[3] = (a != b) && (c > d);
            res[4] = !(a != b);
            res[5] = (a == b) ^ (c < d);
            return res;
        }
    }
}
