string a = Console.ReadLine();

int count = 0;

string b = "";

bool can = true;

int c = a.Length;

for (int i = 0; i < c; i++)
{
    a += "     ";
    if (count > 0)
    {
        count--;
        continue;
    }

    if (a[i] == '.')
    {
        b += ".";
    }
    else if (a[i] == 'X' && a[i + 1] == 'X' && a[i + 2] == 'X' && a[i + 3] == 'X')
    {
        count = 3;
        b += "AAAA";
    }
    else if (a[i] == 'X' && a[i + 1] == 'X')
    {
        count = 1;
        b += "BB";
    }
    else
    {
        can = false;
    }

}
if(can) Console.WriteLine(b);
else Console.WriteLine(-1);