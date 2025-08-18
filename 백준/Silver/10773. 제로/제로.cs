int a = int.Parse(Console.ReadLine());

int[] arr = new int[100000];

int index = 0;

int sum = 0;

for (int i = 0; i < a; i++)
{
    int b = int.Parse(Console.ReadLine());

    if (b != 0)
    {
        arr[index] = b;
        index++;
    }
    else
    {
        index--;
        arr[index] = 0;
    }
}

foreach (var value in arr)
{
    sum += value;
}
Console.WriteLine(sum);