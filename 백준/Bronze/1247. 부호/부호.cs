using System.Numerics;

int a = 0;
BigInteger b = 0;
for (int i = 0; i < 3; ++i)
{
    a = int.Parse(Console.ReadLine());
    b = 0;
    for (int j = 0; j < a; j++)
    {
        b += BigInteger.Parse(Console.ReadLine());
    }
    if(b > 0)
        Console.WriteLine("+");
    else if(b < 0)
        Console.WriteLine("-");
    else
        Console.WriteLine(0);
}