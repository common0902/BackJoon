int a = int.Parse(Console.ReadLine());

int b = 1;

while (b < a)
{
    int c = b;
    int d = b;
    while (d > 0)
    {
        c += d % 10;
        d /= 10;
    }

    if (c == a) break;  
    ++b;
}

if(b == a)
    Console.WriteLine(0);
else
    Console.WriteLine(b);