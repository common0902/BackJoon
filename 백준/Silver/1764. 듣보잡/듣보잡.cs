using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, bool> myDictionary = new Dictionary<string, bool>();

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int a = arr[0];
            int b = arr[1];

            string c = "";
            string d = "";

            string[] arr2 = new string[b];

            int count = 0;

            for (int i = 0; i < a; i++)
            {
                c = Console.ReadLine();
                myDictionary.Add(c, true);
            }

            for (int i = 0; i < b; i++)
            {
                d = Console.ReadLine();
                if (myDictionary.ContainsKey(d))
                {
                    arr2[i] = d;
                    count++;
                }
            }
            Array.Sort(arr2);

            foreach (string s in arr2)
            {
                if(s != null)
                    sb.AppendLine(s);
            }

            Console.WriteLine(count);
            Console.WriteLine(sb);
        }
    }
}