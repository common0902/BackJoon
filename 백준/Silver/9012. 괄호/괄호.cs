using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int a = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < a; i++)
            {
                string b = Console.ReadLine();

                int count = 0;
                bool can = true;

                for (int j = 0; j < b.Length; j++)
                {

                    if (b[j] == '(') count++;
                    else if (b[j] == ')') count--;

                    if (count < 0)
                    {
                        can = false;
                        break;
                    }
                    

                }
                if(count != 0) can = false; 
                
                if (can) sb.AppendLine("YES");
                else sb.AppendLine("NO");
            }
            Console.WriteLine(sb);
        }
    }
}