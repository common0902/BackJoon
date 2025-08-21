using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            int[] arr = new int[a];

            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());

                arr[i] = b;
            }
            Array.Sort(arr);

            for (int i = 0; i < a; i++)
            {
                sb.AppendLine(arr[i].ToString());
            }
            Console.WriteLine(sb);
        }
    }
}