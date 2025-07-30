int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < 1 + i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine(" ");

}
for (int i = 0; i < a-1; i++)
{
    for (int j = a; j > i+1; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine(" ");


}