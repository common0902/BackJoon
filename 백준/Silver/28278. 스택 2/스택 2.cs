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
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int b = arr[0];

                switch (b)
                {
                    case 1:
                        stack.Push(arr[1]);
                        break;

                    case 2:
                        if (stack.Count == 0) sb.AppendLine("-1");
                        else sb.AppendLine(stack.Pop().ToString());
                        break;

                    case 3:
                        sb.AppendLine(stack.Count.ToString());
                        break;

                    case 4:
                        if (stack.Count == 0) sb.AppendLine("1");
                        else sb.AppendLine("0");
                        break;

                    case 5:
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