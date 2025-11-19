long a = long.Parse(Console.ReadLine());

switch (a % 3)
{
    case 0:
        Console.WriteLine("S");
        break;
    case 1:
        Console.WriteLine("U");
        break;
    case 2:
        Console.WriteLine("O");
        break;
}