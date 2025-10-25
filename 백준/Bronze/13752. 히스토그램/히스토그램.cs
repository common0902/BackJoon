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
                int b = int.Parse(Console.ReadLine());
                for (int j = 0; j < b; j++)
                {
                    sb.Append("=");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }

    }
}