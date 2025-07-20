using System.Numerics;
using System.Runtime.Serialization;
using System.Text;

namespace ConsoleApp4
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            int x = A * B * C;
            string X = x.ToString();
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                count = 0;
                string I = i.ToString();

                for (int j = 0; j < X.Length; j++)
                {
                    int y = int.Parse(X);
                    if (I[0] == X[j]) count++;
                }

                Console.WriteLine(count);
            }
        }

    }
}