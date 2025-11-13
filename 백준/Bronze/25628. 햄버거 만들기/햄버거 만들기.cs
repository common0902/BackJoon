int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = ab[0];
int b = ab[1];

Console.WriteLine(Math.Min(b, a / 2));