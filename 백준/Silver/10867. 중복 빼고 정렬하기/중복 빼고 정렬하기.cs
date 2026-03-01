int a = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Array.Sort(arr);

for (int i = 0; i < arr.Length; i++)
{
    if (i == 0)
    {
        Console.Write(arr[0] + " ");
        continue;
    }

    if (arr[i] != arr[i - 1])
    {
        Console.Write(arr[i] + " ");
    }
}