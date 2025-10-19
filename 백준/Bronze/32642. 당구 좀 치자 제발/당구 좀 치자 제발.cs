int a = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

long num = 0;
long num2 = 0;

for (int i = 0; i < a; i++)
{
    if (arr[i] == 1)
        num += 1;
    else
        num -= 1;

    num2 += num;
}

Console.WriteLine(num2);