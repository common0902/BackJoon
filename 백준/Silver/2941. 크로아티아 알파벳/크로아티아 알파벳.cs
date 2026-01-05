string a = Console.ReadLine();

int count = 0;

for (int i = 0; i < a.Length; i++)
{
    count++;

    switch (a[i])
    {
        case 'c':
            if (i + 1 >= a.Length)
                break;
            if (a[i + 1] == '=' || a[i + 1] == '-')
                i++;
            break;
        case 'd':
            if (i + 1 >= a.Length)
                break;
            if (a[i + 1] == '-')
            {
                i++;
                break;
            }
            if (i + 2 >= a.Length)
                break;
            if (a[i + 1] == 'z' && a[i+2] == '=')
                i += 2;
            break;
        case 'l' or 'n':
            if (i + 1 >= a.Length)
                break;
            if (a[i + 1] == 'j')
                i++;
            break;
        case 's' or 'z':
            if (i + 1 >= a.Length)
                break;
            if (a[i + 1] == '=')
                i++;
            break;
        default:
            break;
    }
}
Console.WriteLine(count);