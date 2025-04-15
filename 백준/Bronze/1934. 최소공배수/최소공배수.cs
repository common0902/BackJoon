namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                long[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
                long a = ab[0];
                long b = ab[1];
                long c = ab[0];
                long d = ab[1];

                while (true)
                {
                    if (c > d)
                    {
                        d += b;
                    }
                    else if (c < d)
                    {
                        c += a;
                    }
                    else if (c == d)
                    {
                        Console.WriteLine($"{c}");
                        break;
                    }
                }
            }
                
        }
    }
}