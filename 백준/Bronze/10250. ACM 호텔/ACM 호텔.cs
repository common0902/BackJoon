int n = int.Parse(Console.ReadLine());

int w = 1;

for (int i = 0; i < n; i++)
{

    int[] abc = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    int a = abc[0];
    int b = abc[1];
    int c = abc[2];
    w = 1;

    while (true)
    {
        if (a < c || 0 < c)
        {
            c -= a;
            w++;
        }
        if (c <= 0)
        {
            c += a;
            w--;
            break;
        }
    }
    if (w < 10)
    {
        Console.WriteLine($"{c}{0}{w}");
    }
    else
    {
        Console.WriteLine($"{c}{w}");
    }

}