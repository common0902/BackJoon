int a = int.Parse(Console.ReadLine());

for (int i = 0; i < a; i++)
{
    string b = Console.ReadLine();
    if(b.Contains('S'))
        Console.WriteLine(b);
}