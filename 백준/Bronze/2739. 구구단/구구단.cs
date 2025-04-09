using Microsoft.VisualBasic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*double[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
            double a = ab[0];
            double b = ab[1];*/
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} * 1 = {a*1} ");
            Console.WriteLine($"{a} * 2 = {a*2} ");
            Console.WriteLine($"{a} * 3 = {a*3} ");
            Console.WriteLine($"{a} * 4 = {a*4} ");
            Console.WriteLine($"{a} * 5 = {a*5} ");
            Console.WriteLine($"{a} * 6 = {a*6} ");
            Console.WriteLine($"{a} * 7 = {a*7} ");
            Console.WriteLine($"{a} * 8 = {a*8} ");
            Console.WriteLine($"{a} * 9 = {a*9} ");
            
        }
    }
}