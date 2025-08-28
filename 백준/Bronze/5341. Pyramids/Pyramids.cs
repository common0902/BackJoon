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
            while (true)
            {
                int sum = 0;
                int a = int.Parse(Console.ReadLine());

                if (a == 0) break;

                for (int i = 1; i <= a; i++)
                {
                    sum += i;
                }

                sb.AppendLine(sum.ToString());
                
            }
            Console.WriteLine(sb);
        }
    }
}