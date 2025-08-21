using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = a; i > 0; i--)
            {
                sb.AppendLine(i.ToString());
            }

            Console.WriteLine(sb);
        }
    }
}