string a = Console.ReadLine();
string b = Console.ReadLine();

bool can = false;
int count = 0;

for (int i = 0; i < a.Length; i++)
{
    if (a[i] == b[0])
    {
        for (int j = 0; j < b.Length; j++)
        {
            if (i + j >= a.Length)
            {
                can = false;
                break;
            }

            if (a[i + j] == b[j])
            {
                can = true;
            }
            else
            {
                can = false;
                break;
            }
        }
    }

    if (can)
    {
        count++;
        i += b.Length - 1;
        can = false;
        continue;
    }

}
Console.WriteLine(count);