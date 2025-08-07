int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int a = ab[0];
int b = ab[1];

int[] arr = new int[1000];

int idx = 0;
int num = 0;

for (int i = 1; idx < b; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (idx >= b) break;
        arr[idx++] = i;
    }
}

for (int i = a; i <= b; i++)
{
    num += arr[i - 1];
}

Console.WriteLine(num);