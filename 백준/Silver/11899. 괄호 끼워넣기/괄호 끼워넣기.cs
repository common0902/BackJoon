string a = Console.ReadLine();

int count1 = 0;
int count2 = 0;

for (int i = 0; i < a.Length; i++)
{
    if (a[i] == '(')
    {
        if (count1 < 0)
            count1 = 0;
        count1++;
    }
    else
    {
        if (count1 <= 0)
        {
            count2++;
        }
        count1--;
    }
}
if(count1 < 0)
    count1 = 0;
Console.WriteLine(count2 + count1);