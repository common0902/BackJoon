using System.Numerics;
using System.Runtime.Serialization;
using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            BigInteger[] ab = Array.ConvertAll(Console.ReadLine().Split(' '),BigInteger.Parse);

            BigInteger a = ab[0];
            BigInteger b = ab[1];

            Console.WriteLine(a+b);
        }
    }
}