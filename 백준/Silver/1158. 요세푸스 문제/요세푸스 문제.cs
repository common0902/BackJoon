using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Queue<int> queue = new Queue<int>();

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            int a = arr[0];
            int b = arr[1];

            sb.Append("<");

            for (int i = 1; i <= a; i++)
            {
                queue.Enqueue(i);
            }

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b-1; j++)
                {
                    int c = queue.Dequeue();
                    queue.Enqueue(c);
                }
                sb.Append(queue.Dequeue());
                if(i != a-1)
                    sb.Append(", ");
            }

            sb.Append(">");

            Console.WriteLine(sb);
        }
            
    }
}
