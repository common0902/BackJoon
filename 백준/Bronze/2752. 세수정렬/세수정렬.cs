using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Array.Sort(arr);

            foreach (int i in arr)
            {
                sb.Append($"{i} ");
            }

            Console.WriteLine(sb);
        }
        
    }

}