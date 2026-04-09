int a = int.Parse(Console.ReadLine());

for (int i = 0; i < a; i++)
{
    int b = int.Parse(Console.ReadLine());
    string[] arr = new string[b];
    int count = 1;
    for (int j = 0; j < b; j++)
    {
        arr[j] = Console.ReadLine();
    }
    Array.Sort(arr);
    for (int j = 1; j < arr.Length; j++)
    {
        if (arr[j] != arr[j - 1]) count++;
    }
    Console.WriteLine(count);
}