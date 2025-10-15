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
                if(b.Length >= 6 && b.Length <= 9) sb.AppendLine("yes");
                else sb.AppendLine("no");
            }
            Console.WriteLine(sb);
        }

    }
}