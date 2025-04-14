namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < 1 + i; j++)
                {
                    Console.Write("*");
                }
                    Console.WriteLine(" ");
                
            }
            
        }
    }
}
