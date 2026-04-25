int a = int.Parse(Console.ReadLine());

for (int i = 0; i < a; i++)
{
    string b = Console.ReadLine();
    if (b == "yonsei")
    {
        Console.WriteLine("Yonsei Won!");
        break;
    }
    if (b == "korea")
    {
        Console.WriteLine("Yonsei Lost...");
        break;
    }
}