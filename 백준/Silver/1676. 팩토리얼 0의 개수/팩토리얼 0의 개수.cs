using System.Numerics;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            BigInteger num = Factorial(a);

            int count = 0;

            while (true)
            {
                if (num % 10 != 0) break;
                else count++;
                num /= 10;
            }

            Console.WriteLine(count);
        }
        static BigInteger Factorial(BigInteger a)
        {
            if (a == 1 || a == 0) return 1;
            return Factorial(a - 1) * a;
        }

    }
}