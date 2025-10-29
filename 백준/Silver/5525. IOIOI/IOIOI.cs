int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
string c = Console.ReadLine();

int count = 0;

bool can = true;

for (int i = 0; i < b; i++)
{
    can = true;

    if (c[i] == 'I')
    {
        for (int j = 1; j <= a * 2; j++)
        {
            if (i + j >= c.Length)
            {
                can = false;
                break;
            }

            if (j % 2 == 1)
            {
                if (c[i + j] != 'O')
                {
                    can = false;
                }
            }
            else
            {
                if (c[i + j] != 'I')
                {
                    can = false;
                }
            }
        }
        if (can)
            count++;
    }
    
}
Console.WriteLine(count);