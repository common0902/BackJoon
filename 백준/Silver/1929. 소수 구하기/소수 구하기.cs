using System;

class Program
{
    static void Main()
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int a = arr[0];
        int b = arr[1];

        bool[] isPrime = new bool[b + 1];

        for (int i = 2; i <= b; i++)
            isPrime[i] = true;

        for (int i = 2; i * i <= b; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= b; j += i)
                    isPrime[j] = false;
            }
        }

        for (int i = a; i <= b; i++)
        {
            if (isPrime[i])
                Console.WriteLine(i);
        }
    }
}
