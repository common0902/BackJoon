int a = int.Parse(Console.ReadLine());
int q = a;
for (int i = 0; i < a; i++,q--)
{
    for (int j = 0; j < 1 + i; j++)
    {
        Console.Write("*");
    }
    for (int j = 0; j < (q - 1) * 2; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < 1 + i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine("");
}
for (int i = 0; i < a-1 ; i++, q--)
{
    for (int j = a; j -1 > i; j--)
    {
        Console.Write("*");
    }

    for (int j = 0; j < (i+1) * 2; j++)
    {
        Console.Write(" ");
    }
    for (int j = a; j-2> i; j--)
    {
        Console.Write("*");
    }

    Console.WriteLine("*");
}