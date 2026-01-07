int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a < 2)
{
    Console.WriteLine("Before");
}
else if (a > 2)
{
    Console.WriteLine("After");
}
else
{
    if (b < 18)
        Console.WriteLine("Before");
    else if (b > 18)
        Console.WriteLine("After");
    else
        Console.WriteLine("Special");
}