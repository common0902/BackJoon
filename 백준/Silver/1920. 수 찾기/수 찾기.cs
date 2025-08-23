using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, bool> myDictionary = new Dictionary<string, bool>();

            int a = int.Parse(Console.ReadLine());
            int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int b = int.Parse(Console.ReadLine());
            int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            for (int i = 0; i < arr1.Length; i++)
            {
                myDictionary.TryAdd(arr1[i].ToString(), false);
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                if (myDictionary.ContainsKey(arr2[i].ToString()))
                {
                    sb.AppendLine("1");
                }
                else
                {
                    sb.AppendLine("0");
                }
            }

            Console.WriteLine(sb);
        }
    }
}