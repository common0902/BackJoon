int a = int.Parse(Console.ReadLine());
int[] arr = new int[a];

for (int i = 0; i < arr.Length; i++)
{
    int b = int.Parse(Console.ReadLine());
    arr[i] = b;
}
Array.Sort(arr);
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}