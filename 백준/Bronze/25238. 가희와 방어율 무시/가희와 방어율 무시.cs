int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int a = ab[0];
int b = ab[1];

if ((long)a * (100 - b) < 10000)
{
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(0);
}