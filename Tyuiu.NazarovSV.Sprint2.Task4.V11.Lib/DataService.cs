﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NazarovSV.Sprint2.Task4.V11.Lib
{
    public class DataService : ISprint2Task4V11
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(((x - 20 * 2 < y / 4 ? Math.Pow((3 + (8 / x * x)), y) : y - Math.Pow(((x + 1) / (y + 2)), x))), 3);
        }
    }
}
