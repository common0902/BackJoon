using Microsoft.VisualBasic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}");

                int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int a = ab[0];
                int b = ab[1];

                Console.WriteLine(a + b);
        }
    }
}