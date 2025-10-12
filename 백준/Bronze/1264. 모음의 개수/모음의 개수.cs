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

                if (a[0] == '#') break;

                int count = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u'
                        || a[i] == 'A' || a[i] == 'E' || a[i] == 'I' || a[i] == 'O' || a[i] == 'U')
                    {
                        count++;
                    }
                }
                sb.AppendLine(count.ToString());

            }
            Console.WriteLine(sb);
        }

    }
}