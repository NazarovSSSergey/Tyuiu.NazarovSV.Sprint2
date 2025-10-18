using Tyuiu.NazarovSV.Sprint2.Task7.V12.Lib;
namespace Tyuiu.NazarovSV.Sprint2.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("* Введите значение переменной X:                                         *");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("* Введите значение переменной Y:                                         *");
            double y = Convert.ToDouble(Console.ReadLine());
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            if (res) { Console.WriteLine("Точка находится в закрашенной облати"); }
            else { Console.WriteLine("Точка не находится в закрашенной области"); }
            Console.ReadKey();
        }
    }
}
