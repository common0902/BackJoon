int a = int.Parse(Console.ReadLine());
string[] arr = Console.ReadLine().Split();

for (int i = 0; i < a; i++)
{
    int b = int.Parse(arr[i]);

    if (b == 300)
        Console.Write("1 ");
    else if (b >= 275)
        Console.Write("2 ");
    else if (b >= 250)
        Console.Write("3 ");
    else
        Console.Write("4 ");
}