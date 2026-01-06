int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int a = arr[0];
int b = arr[1];

int[] baguni = new int[a];

for (int i = 0; i < b; i++)
{
    int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    for (int j = arr2[0]; j <= arr2[1]; j++)
    {
        baguni[j-1] = arr2[2];
    }
}

foreach (int i in baguni)
{
    Console.Write(i + " ");
}