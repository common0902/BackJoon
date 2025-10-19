using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Stack<int> stack = new Stack<int>();

            int a = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < a; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');
                string b = arr[0];

                switch(b)
                {
                    case "push":
                        stack.Push(int.Parse(arr[1]));
                        break;

                    case "pop":
                        if (stack.Count == 0) sb.AppendLine("-1");
                        else sb.AppendLine(stack.Pop().ToString());
                        break;

                    case "size":
                        sb.AppendLine(stack.Count.ToString());
                        break;

                    case "empty":
                        if (stack.Count == 0) sb.AppendLine("1");
                        else sb.AppendLine("0");
                        break;

                    case "top":
                        if (stack.Count == 0) sb.AppendLine("-1");
                        else
                        {
                            sb.AppendLine(stack.Peek().ToString());
                        }
                        break;


                }
                
            }
            Console.WriteLine(sb);
        }
            
    }
}