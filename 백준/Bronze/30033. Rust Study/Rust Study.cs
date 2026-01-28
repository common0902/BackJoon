int a = int.Parse(Console.ReadLine());

int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

int count = 0;

for (int i = 0; i < a; i++)
{
    if (arr2[i] >= arr1[i])
        count++;
}

Console.WriteLine(count);