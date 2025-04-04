namespace CS_250404
{
    internal class Program
    {
        static int FindMax(int x, int y, int z)
        {
            int max = x;
            if (max < y)
                max = y;
            if (max < z)
                max = z;

            return max;
        }
        static void Main(string[] args)
        {
            int[] dice = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            if (dice[0] == dice[1] && dice[1] == dice[2])
            {
                Console.WriteLine(10000 + dice[0] * 1000);
            }
            else if (dice[0] == dice[1] || dice[0] == dice[2])
            {
                Console.WriteLine(1000 + dice[0] * 100);
            }
            else if (dice[1] == dice[2])
            {
                Console.WriteLine(1000 + dice[1] * 100);
            }
            else
            {
                Console.WriteLine(FindMax(dice[0], dice[1], dice[2]) * 100);
            }
        }
    }
}