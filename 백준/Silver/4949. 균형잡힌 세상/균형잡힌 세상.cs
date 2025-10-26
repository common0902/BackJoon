using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string a = Console.ReadLine();
                if (a == ".") break;

                Stack<char> stack = new Stack<char>();
                bool can = true;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == '(') stack.Push('(');
                    else if (a[i] == '[') stack.Push('[');
                    else if (a[i] == ')')
                    {
                        if (stack.Count == 0 || stack.Pop() != '(')
                        {
                            can = false;
                            break;
                        }
                    }
                    else if (a[i] == ']')
                    {
                        if (stack.Count == 0 || stack.Pop() != '[')
                        {
                            can = false;
                            break;
                        }
                    }
                }

                if (can && stack.Count == 0)
                    sb.AppendLine("yes");
                else
                    sb.AppendLine("no");
            }

            Console.WriteLine(sb);
        }
    }

}