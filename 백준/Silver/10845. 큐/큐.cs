using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Queue<int> queue = new Queue<int>();

            int a = int.Parse(Console.ReadLine());

            
            

            for (int i = 0; i < a; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');
                string b = arr[0];

                switch(b)
                {
                    case "push":
                        queue.Enqueue(int.Parse(arr[1]));
                        break;
                    case "pop":
                        if (queue.Count == 0) sb.AppendLine("-1");
                        else sb.AppendLine(queue.Dequeue().ToString());
                        break;
                    case "size":
                        sb.AppendLine(queue.Count.ToString());
                        break;
                    case "empty":
                        if (queue.Count == 0) sb.AppendLine("1");
                        else sb.AppendLine("0");
                        break;
                    case "front":
                        if (queue.Count == 0) sb.AppendLine("-1");
                        else
                        {
                            Queue<int> queue2 = new Queue<int>(queue);
                            sb.AppendLine(queue2.Dequeue().ToString());
                        }
                        break;
                    case "back":
                        if (queue.Count == 0) sb.AppendLine("-1");
                        else
                        {
                            Queue<int> queue2 = new Queue<int>(queue.Reverse());
                            sb.AppendLine(queue2.Dequeue().ToString());
                        }
                        break;
                }
                
            }

            Console.WriteLine(sb);
        }
            
    }
}