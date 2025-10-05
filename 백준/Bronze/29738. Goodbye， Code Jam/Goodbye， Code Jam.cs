int a = int.Parse(Console.ReadLine());
for (int i = 1; i <= a; i++)
{
    int b = int.Parse(Console.ReadLine());
    string c;

    if (b > 4500)
        c = "Round 1";
    else if (b > 1000)
        c = "Round 2";
    else if (b > 25)
        c = "Round 3";
    else
        c = "World Finals";

    Console.WriteLine($"Case #{i}: {c}");
}