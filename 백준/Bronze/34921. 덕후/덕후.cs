int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int a = arr[0];
int b = arr[1];

int c = 10 + 2 * (25 - a + b);

if (c < 0)
    c = 0;

Console.WriteLine(c);