int count = 0;

for (int i = 0; i < 8; i++)
{
    string a = Console.ReadLine();

    foreach (char c in a)
    {
        int b = 0;

        switch (char.ToLower(c))
        {
            case 'p': b = 1; break;
            case 'n': b = 3; break;
            case 'b': b = 3; break;
            case 'r': b = 5; break;
            case 'q': b = 9; break;
            case 'k': b = 0; break;
        }

        if (char.IsUpper(c))
            count += b;
        else
            count -= b;
    }
}

Console.WriteLine(count);