using Microsoft.VisualBasic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            double result=0;
            foreach(int i in ab)
            {
                result += Math.Pow(i, 2);
            }
            result = result % 10;
            Console.WriteLine($"{result}");
        }
    }
}