int a = int.Parse(Console.ReadLine());
int num = 0;

for (int i = 0; i < a; i++)
{
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int b = arr[0];

    if (b == 136) num += 1000;
    else if (b == 142) num += 5000;
    else if (b == 148) num += 10000;
    else if (b == 154) num += 50000;
}

Console.WriteLine(num);