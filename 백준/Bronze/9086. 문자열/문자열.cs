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
                string b = Console.ReadLine();

                sb.AppendLine($"{b[0]}{b[b.Length - 1]}");
            }
            Console.WriteLine(sb);
        }
    }
}