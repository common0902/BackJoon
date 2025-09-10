using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int count = 0;
            

            for (int i = 0; i < a; i++)
            {
                Dictionary<char, bool> myDictionary = new Dictionary<char, bool>();
                string c = Console.ReadLine();

                char b = ' ';
                bool check = true;

                for (int j = 0; j < c.Length; j++)
                {
                    if (b != c[j])
                    {
                        if (myDictionary.ContainsKey(c[j]) == false)
                        {
                            myDictionary.Add(c[j], true);
                        }
                        else
                        {
                            check = false;
                            break;
                        }
                    }
                    b = c[j];
                }
                if (check)
                {
                   count++;
                }
            }
            
            Console.WriteLine(count);

        }
        

    }
}