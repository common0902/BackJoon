using System.Threading.Channels;
using Microsoft.VisualBasic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());

            if (a % 4 == 0 && a % 100 != 0)
            {
                Console.WriteLine("1");
            }
            else if (a % 400 == 0)
            {
                Console.WriteLine("1");

            }
            else if (a % 4 == 0 && a % 100 == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}