int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
int e = int.Parse(Console.ReadLine());

int count = 0;

if (a < 0)
{
    count += (-a) * c;
    count += d;
    count += b * e;
}
else
{
    count += (b - a) * e;
}

Console.WriteLine(count);