using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NazarovSV.Sprint2.Task4.V11.Lib
{
    public class DataService : ISprint2Task4V11
    {
        public double Calculate(double x, double y)
        {
            double a = (x-20*2);
            double c = (y / 4);
            double z = Math.Pow((3 + (8 / x * x)), y);
            double z2 = y - Math.Pow(((x + 1) / (y + 2)), x);
            double z3 = a < c ? z : z2;
            return Math.Round(z3, 3);
        }
    }
}
