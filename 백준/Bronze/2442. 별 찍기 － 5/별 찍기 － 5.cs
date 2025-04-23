int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    for (int j = a; j > i+1; j--)
    {
        Console.Write(" ");
    }
    for (int j =0;j < i * 2; j++)
    {
        Console.Write("*");
    }
    
    Console.WriteLine("*");
}