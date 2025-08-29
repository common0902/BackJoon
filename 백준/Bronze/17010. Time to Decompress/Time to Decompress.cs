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
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');
                int b = int.Parse(arr[0]);
                string c = arr[1];
                for (int j = 0; j < b; j++)
                {
                    sb.Append(c);
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
    }
}