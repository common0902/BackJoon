using System.Text;
using System.Numerics;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                BigInteger b = BigInteger.Parse(Console.ReadLine());

                if (b % 2 == 0) sb.AppendLine("even");
                else sb.AppendLine("odd");
            }
            Console.WriteLine(sb);
        }
    }
}