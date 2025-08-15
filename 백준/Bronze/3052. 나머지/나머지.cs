int[] a = new int[10];

int count = 0;

for (int i = 0; i < 10; i++)
{
    int b = int.Parse(Console.ReadLine());

    bool can = true;

    for (int j = 0; j < count; j++)
    {
        if (a[j] == b % 42)
        {
            can = false;
            break;
        }
    }
    if (can)
    {
        a[count] = b % 42;
        count++;
    }
}
Console.WriteLine(count);