int a = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int count = 0;

foreach (int b in arr)
{
    if (b == a) count++;

}

Console.WriteLine(count);