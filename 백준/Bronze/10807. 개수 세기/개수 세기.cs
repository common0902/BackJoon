int a = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int b = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 0; i < a; i++)
{
    if (arr[i] == b)
    {
        count++;
    }
}

Console.WriteLine(count);