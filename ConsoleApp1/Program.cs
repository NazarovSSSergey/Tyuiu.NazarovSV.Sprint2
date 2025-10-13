namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;

            int y = (x > 0) && (x < 2) ? x * x : -x;
            Console.WriteLine(y);
        }
    }
    }
}
