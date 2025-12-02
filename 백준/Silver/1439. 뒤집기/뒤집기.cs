string a = Console.ReadLine();

int count = -1;
float count1 = 0;

for (int i = 0; i < a.Length; i++)
{
    if (count != int.Parse(a[i].ToString()))
    {
        count = int.Parse(a[i].ToString());
        count1++;
    }
}

Console.WriteLine((int)(count1 / 2));