int a = int.Parse(Console.ReadLine());

int[] arr = new int[a];

for (int i = 0; i < a; i++)
{
    arr[i] = int.Parse(Console.ReadLine());

}

int b = int.Parse(Console.ReadLine());
int num = 0;
for (int i = 0; i < b; i++)
    num += arr[int.Parse(Console.ReadLine()) - 1];

Console.WriteLine(num);