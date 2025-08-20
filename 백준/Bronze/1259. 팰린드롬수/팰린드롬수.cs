while (true)
{
    string a = Console.ReadLine();

    if (a == "0") break;  

    bool can = true;

    for (int i = 0; i < a.Length / 2; i++)
    {
        if (a[i] != a[a.Length - 1 - i])
        {
            can = false;
            break;
        }
    }

    if (can)
        Console.WriteLine("yes");
    else
        Console.WriteLine("no");
}