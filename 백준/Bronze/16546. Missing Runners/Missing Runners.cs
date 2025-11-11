int a = int.Parse(Console.ReadLine());
string[] arr = Console.ReadLine().Split(' ');
int[] arr2 = new int[a - 1];

for (int i = 0; i < a - 1; i++)
{
    arr2[i] = int.Parse(arr[i]);
}

int b = a * (a + 1) / 2;
int num = 0;

for (int i = 0; i < a - 1; i++)
{
    num += arr2[i];
}

Console.WriteLine(b - num);