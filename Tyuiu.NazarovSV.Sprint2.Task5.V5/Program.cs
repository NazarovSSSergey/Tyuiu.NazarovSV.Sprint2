using Tyuiu.NazarovSV.Sprint2.Task5.V5.Lib;
namespace Tyuiu.NazarovSV.Sprint2.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Введите номер карты: ");
            int cn = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((cn < 6) || (cn > 14))
            {
                res = "Введено неверное значение";
            }
            else
            {
                res = "Это месяц: " + ds.FindCardValue(cn);
            }
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ      :                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
