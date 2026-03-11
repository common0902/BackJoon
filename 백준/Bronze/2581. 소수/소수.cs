int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

bool c = true;
int d = 0;

int num = 0;

for (int i = a; i <= b; i++)
{
    bool can = true;

    if (i == 1) continue;

    for (int j = 2; j <= MathF.Sqrt(i); j++)
    {
        if (i % j == 0) can = false;
    }

    if (can)
    {
        if (c)
        {
            c = false;
            d = i;
        }
        num += i;
    }
}
if (!c)
{
    Console.WriteLine(num);
    Console.WriteLine(d);
}
else
{
    Console.WriteLine(-1);
}