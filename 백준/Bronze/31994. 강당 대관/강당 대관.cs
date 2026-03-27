using System;

class Program
{
    static void Main()
    {
        string a = "";
        int b = 0;

        for (int i = 0; i < 7; i++)
        {
            string[] arr = Console.ReadLine().Split();
            int c = int.Parse(arr[1]);

            if (c > b)
            {
                b = c;
                a = arr[0];
            }
        }

        Console.WriteLine(a);
    }
}