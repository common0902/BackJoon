int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int a = ab[0];
int b = ab[1];

int num = a * 100;

if (num >= b)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");