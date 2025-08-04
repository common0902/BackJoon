long[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
long a = ab[0];
long b = ab[1];

if (b == 1)
{
    Console.WriteLine(-1);
}
else
{
        a = (a * b + (b - 2)) / (b - 1);
        Console.WriteLine(a);
}