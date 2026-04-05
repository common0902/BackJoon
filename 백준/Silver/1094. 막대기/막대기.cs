int a = int.Parse(Console.ReadLine());
int[] arr = { 64, 32, 16, 8, 4, 2, 1 };
int b = 0;
int count = 0;
for (int i = 0; i < arr.Length; ++i)
{
    b += arr[i];
    ++count;
    if (b == a) break;
    else if (b > a)
    {
        count--;
        b -= arr[i];
    }
}
Console.WriteLine(count);