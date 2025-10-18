using System.Runtime.InteropServices;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NazarovSV.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((x <= -2 && y >= 4) || (x >= 0 && x <= 2 && y >= 0 && y <= 1)) { res = true; }
            else { res = false; }
            return res;
        }
    }
}
