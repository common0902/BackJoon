using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int a = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();

            int count = 0;

            for (int i = 1; i <= a; i++)
            {
                queue.Enqueue(i);
            }

            while (true)
            {
                if (queue.Count == 0) break;

                if (count % 2 == 0)
                {
                    sb.Append($"{queue.Dequeue().ToString()} ");
                }
                else
                {
                    int b = queue.Dequeue();
                    queue.Enqueue(b);
                }
                count++;
            }
            Console.WriteLine(sb);
            
        }


        }

    }