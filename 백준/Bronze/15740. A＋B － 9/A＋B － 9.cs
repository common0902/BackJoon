using System.Numerics;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), BigInteger.Parse);
            Console.WriteLine(ab[0] + ab[1]);
        }
    }
}
