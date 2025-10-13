using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NazarovSV.Sprint2.Task4.V11.Lib
{
    public class DataService : ISprint2Task4V11
    {
        public double Calculate(double x, double y)
        {
            var z = x - 20 * 2;
            var z1 = y / 4;
            var z2 = Math.Pow((3 + (8 / Math.Pow(x, 2))), y);
            var z3 = y - Math.Pow(((x + 1) / (y + 2)), x);
            var z4 = z < z1 ? z2 : z3;
            return Math.Round(z4, 3);
        }
    }
}
