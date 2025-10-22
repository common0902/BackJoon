int[] arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int a = arr[0];
int b = arr[1];
int c = arr[2];

c -= a;
int count = 1;

if (a - b != 1)
{
    while (true)
    {
        if (c <= 0) break;

        c -= (a - b);

        count++;
    }
}
else
{
    count += c / (a - b);
}

Console.WriteLine(count);