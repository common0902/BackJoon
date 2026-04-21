string a = Console.ReadLine();

int count = 0;

for (int i = 0; i < a.Length; i++)
{
    if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
    {
        count++;
    }
}
Console.WriteLine(count);