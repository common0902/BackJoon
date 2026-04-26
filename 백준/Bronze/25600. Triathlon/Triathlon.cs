int a = int.Parse(Console.ReadLine());
long max = -1;
for (int i = 0; i < a; i++)
{
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(" "),int.Parse);
    int b = arr[0];
    int c = arr[1];
    int d = arr[2];

    long num = b * (c + d);

    if (b == c + d)
    {
        num *= 2;
    }

    if(max < num) max = num;
}
Console.WriteLine(max);