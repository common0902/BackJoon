int[] arr1 = new int[10];

int num = 0;

for (int i = 0; i < 10; i++)
{
    int b = int.Parse(Console.ReadLine());
    arr1[i] = b;
    num += b;
}

int[] arr2 = new int[1001];

foreach (int i in arr1)
{
    arr2[i]++;
}

Console.WriteLine(num / 10);
Console.WriteLine(Array.IndexOf(arr2, arr2.Max()));
