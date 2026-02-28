string a = Console.ReadLine();

string[] arr = new string[a.Length];

for (int i = 0; i < a.Length; i++)
{
    for (int j = i; j < a.Length; j++)
    {
        arr[i] += a[j];
    }
}

Array.Sort(arr);

foreach (string i in arr)
{
    Console.WriteLine(i);
}