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
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                sb.AppendLine((arr[0] + arr[1]).ToString());
            }
            Console.WriteLine(sb);
        }

    }
}