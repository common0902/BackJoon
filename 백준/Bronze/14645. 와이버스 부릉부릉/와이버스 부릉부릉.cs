using System.Globalization;
using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for (int i = 0; i < arr1[0]; i++)
            {
                int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            }

            Console.WriteLine("비와이");
        }
    }
}