using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NazarovSV.Sprint2.Task2.V8.Lib
{
    public class DataService : ISprint2Task2V8
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((3 <= x && x <= 5 && y >= 3 && y <= 7) && (x >= 9 && x <= 11 && y >=2 && y <= 4 && x == 12 && y == 3) && (x == 14 && y == 7) && (y == 7 && y == 8 && x == 6 && x == 9 && y == 7 && y == 8) && (y == 11 && x == 3 && x == 4 && x == 5) && (x == 7 && x == 8 && x == 9 && y == 12) && (x >= 6 && x <= 9 && y >= 5 && y <= 6) && (x >= 6 && x <= 9 && y >= 9 && y <= 11) && (x == 10 && x == 11 && y == 6 && y == 7) && (x >= 12 && x <= 13 && y >= 6 && y <= 9))
            {
                res = false;
            }
            else
            {
                res = true;
            }

            return res;
        }
    }
}
