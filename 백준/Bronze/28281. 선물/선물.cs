string[] arr = Console.ReadLine().Split();
int a = int.Parse(arr[0]);
long b = long.Parse(arr[1]);

int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

long c = long.MaxValue;

for (int i = 0; i < a - 1; i++)
{
    long d = (arr1[i] + arr1[i + 1]) * b;
    if (d < c)
        c = d;
}

Console.WriteLine(c);