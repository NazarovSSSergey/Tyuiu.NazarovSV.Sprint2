using Tyuiu.NazarovSV.Sprint2.Task1.V24.Lib;
namespace Tyuiu.NazarovSV.Sprint2.Task1.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 325;
            int b = 325;
            int c = 242;
            int d = 324;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                              *");
            Console.WriteLine("**************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
