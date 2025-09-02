using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            long a = arr[0];
            long b = arr[1];

            long num = 0;

            if (a > b) num = Choidae(a, b);
            else num = Choidae(b, a);

            for (int i = 0; i < num; i++)
            {
                sb.Append("1");
            }
            Console.WriteLine(sb);

        }

        static long Choidae(long a, long b)
        {
            if (a % b == 0) return b;
            else return Choidae(b, a % b);
        }
    }
}