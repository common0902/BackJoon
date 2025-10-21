namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(Vorxhfldjf(a));
        }
        static long Vorxhfldjf(long a)
        {
            if(a == 0 || a == 1) return 1;

            return Vorxhfldjf(a - 1) * a;
        }
       
            
    }
}