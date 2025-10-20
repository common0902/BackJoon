int a = int.Parse(Console.ReadLine());

int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    while (arr[i] > 0)
    {
        arr[i] -= arr2[0];
        count++;
    }
}
Console.WriteLine(count);
Console.WriteLine($"{a / arr2[1]} {a % arr2[1]}");