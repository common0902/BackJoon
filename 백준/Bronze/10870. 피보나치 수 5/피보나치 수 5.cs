namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(Vlqhskcl(a));
        }

        static int Vlqhskcl(int a)
        {
            if (a == 0) return 0;
            else if (a == 1) return 1;
            else return Vlqhskcl(a - 1) + Vlqhskcl(a - 2);
        }
    }

   
}
