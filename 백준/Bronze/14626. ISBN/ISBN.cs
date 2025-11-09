string a = Console.ReadLine();

bool b = false;

int d = 0;

int num = 0;

for (int i = 0; i < a.Length; ++i)
{
    if (i % 2 == 0)
    {
        if (int.TryParse(a[i].ToString(),out d))
        {
            num += d;
        }
        else
        {
            b = true;
        }
    }
    else
    {
        if (int.TryParse(a[i].ToString(), out d))
        {
            num += d * 3;
        }
    }
}

int count = 0;

if (b)
    d = 1;
else
    d = 3;

while (true)
{
    if (num % 10 == 0) break;

    num += d;

    count++;
}

Console.WriteLine(count);