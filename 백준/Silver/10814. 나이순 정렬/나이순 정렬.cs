using System.Globalization;
using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string[,] arr1 = new string[201, 100001];

            int a = int.Parse(Console.ReadLine());

            int y = 0;

            for (int i = 0; i < a; i++)
            {
                string[] arr2 = Console.ReadLine().Split();
                int b = int.Parse(arr2[0]);
                string c = arr2[1];
                

                arr1[b, y] = c;
                y++;
            }

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    if (arr1[i , j] != null)
                        sb.AppendLine($"{i} {arr1[i, j]}");
                }
            }
            Console.WriteLine(sb);
        }
    }
}
