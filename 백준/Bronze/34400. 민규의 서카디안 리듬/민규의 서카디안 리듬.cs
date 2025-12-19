int a = int.Parse(Console.ReadLine());

for (int i = 0; i < a; i++)
{
    int b = int.Parse(Console.ReadLine());

    double time = (b + 0.5) % 25;

    if (time < 17)
        Console.WriteLine("ONLINE");
    else
        Console.WriteLine("OFFLINE");
}