int a = int.Parse(Console.ReadLine());

for (int i = 0; i < a; i++)
{
    for (int j = a; j > i + 1; j--)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < 1 + i * 2; j++)
    {
        if(j % 2 == 0)
            Console.Write("*");
        else
            Console.Write(" ");
    }

    Console.WriteLine(" ");
}