using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int a = int.Parse(Console.ReadLine());

            List<int> arr = new List<int>();

            for (int i = 0; i < 11; i++)
            {
                if (a <= 0) break;
                else
                {
                    arr.Add(a % 10);
                }
                a /= 10;
            }

            arr.Sort();
            
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                sb.Append(arr[i]);
            }
            Console.WriteLine(sb);
        }
    }
}