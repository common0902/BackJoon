namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int a = arr[0];
            int b = arr[1];

            Console.WriteLine(Vorxhfldjf(a) / (Vorxhfldjf(b) * Vorxhfldjf(a - b)));
        }
        static int Vorxhfldjf(int a)
        {
            if (a == 0 || a == 1) return 1;
            return Vorxhfldjf(a - 1) * a;
        }
            
    }
}