using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                Console.WriteLine(Euclidean(ab[0], ab[1]));

                long a = ab[0];
                long b = ab[1];
                long c = ab[0];
                long d = ab[1];

                while (true)
                {
                    if (c > d)
                    {
                        d += b;
                    }
                    else if (c < d)
                    {
                        c += a;
                    }
                    else if (c == d)
                    {
                        Console.WriteLine($"{c}");
                        break;
                    }
                }

        }
        static int Euclidean(int a, int b)
        {
            if (b == 0)
                return a;
            return Euclidean(b, a % b);
        }

    }
}