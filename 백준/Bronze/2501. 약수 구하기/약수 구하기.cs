int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = arr[0];
int b = arr[1];

int[] arr2 = new int[10000];
int index = 0;

for(int i=1; i <= a; i++)
{
    if (a % i == 0)
    {
        arr2[index++] = i;
    }
}

Console.WriteLine(arr2[b-1]);