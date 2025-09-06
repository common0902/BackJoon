int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = ab[0];
int b = ab[1];

if (a * 2 >= b)
    Console.WriteLine("E");
else
    Console.WriteLine("H");