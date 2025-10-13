using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NazarovSV.Sprint2.Task3.V11.Lib
{
    public class DataService : ISprint2Task3V11
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 0)
            {
                y = Math.Round((x + Math.Pow(((x - 15) / (x - 19)), x)), 3);
            }
            else
            {
                if (x == 0)
                {
                    y = Math.Round(((x * x - Math.Sin(x * x) + 10) / (Math.Pow(x, 2) - Math.Sin(x * x) + 12)), 3);
                }
            }
            if (x < 0 && x > -15)
            {
                y = Math.Round(Math.Pow((1 + (1 / x * x)), x), 3);
            }
            else
            {
                if (x < -15)
                {
                    y = Math.Round((x + 10 * x - (1 / x)), 3);
                }
            }
            return y;
        }
    }
}
