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

            int index = 1;

            bool can = true;

            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());

                if (stack.Count >= 1)
                    if (stack.Peek() > b)
                    {
                        can = false;
                        break;
                    }

                while (true)
                {
                    

                    if (stack.Count >= 1)
                    {
                        if (stack.Peek() == b)
                        {
                            stack.Pop();
                            sb.AppendLine("-");
                            break;
                        }
                        else
                        {
                            sb.AppendLine("+");
                            stack.Push(index);
                            index++;
                        }
                    }
                    else
                    {
                        sb.AppendLine("+");
                        stack.Push(index);
                        index++;
                    }
                    
                }
            }
            if(can)
                Console.WriteLine(sb);
            else
                Console.WriteLine("NO");
            
        }
        
    }

}