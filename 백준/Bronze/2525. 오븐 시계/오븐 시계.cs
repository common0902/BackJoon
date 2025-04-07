namespace CS_250407
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int t = int.Parse(Console.ReadLine());
            int h = hm[0];
            int m = hm[1];

            m += t;

            if (m >= 60)
            {
                h += m / 60;
                m = m % 60;
            }
            if (h >= 24)
            {
                h = h % 24;
            }
            Console.WriteLine($"{h} {m}");

        }
    }
}
