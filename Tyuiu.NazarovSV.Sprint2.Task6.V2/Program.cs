using System.Runtime.InteropServices.Marshalling;
using Tyuiu.NazarovSV.Sprint2.Task6.V2.Lib;

namespace Tyuiu.NazarovSV.Sprint2.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Введите номер месяца: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("**************************************************************************");
            string res;
            if ((x < 1) || (x > 12)) { res = "Введено неверное значение!"; }
            else { res = "Это месяц: " + ds.FindMonthSeason(x); }
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
