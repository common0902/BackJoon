long[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

long a = ab[0];
long b = ab[1];

long A = a;
long B = b;

while (true)
{
    if (a < b)
    {
        a += A;
    }
    else if (a > b)
    {
        b += B;
    }
    else break;
}
Console.WriteLine(a);