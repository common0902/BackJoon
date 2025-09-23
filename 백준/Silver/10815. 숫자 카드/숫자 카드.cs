using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<int, bool> myDictionary = new Dictionary<int, bool>();

            int a = int.Parse(Console.ReadLine());
            int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            foreach (int i in arr1)
            {
                myDictionary[i] = true;
            }

            int b = int.Parse(Console.ReadLine());
            int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            for (int i = 0; i < arr2.Length; i++)
            {
                int count = 0;
                if (myDictionary.ContainsKey(arr2[i]))
                {
                    count++;
                }
                sb.Append(count + " ");
            }
            Console.WriteLine(sb);

        }

    }
}