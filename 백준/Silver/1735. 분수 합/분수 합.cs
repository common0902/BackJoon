namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int num1 = (arr1[1] * arr2[0]) + (arr1[0] * arr2[1]);
            int num2 = arr2[1] * arr1[1];

            int a = Chleorhddirtn(num1, num2);

            Console.WriteLine($"{num1 / a} {num2 / a}");
        }

        static int Chleorhddirtn(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                return Chleorhddirtn(b, a % b);
            }
        }
    }
}