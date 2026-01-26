int a = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int num = 0;
int index = 0;

Array.Sort(arr);

for (int i = a; i > 0; i--)
{
    num += arr[index++] * i;
}
Console.WriteLine(num);