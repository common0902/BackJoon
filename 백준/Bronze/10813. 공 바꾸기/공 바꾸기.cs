int[] arr = Array.ConvertAll(Console.ReadLine().Split(" "),int.Parse);

int[] arr2 = new int[arr[0]];

for (int i = 1; i <= arr[0]; i++)
{
    arr2[i - 1] = i; 
}

for (int i = 0; i < arr[1]; i++)
{
    int[] arr3 = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

    int temp = arr2[arr3[0] - 1];
    arr2[arr3[0] - 1] = arr2[arr3[1] - 1];
    arr2[arr3[1] - 1] = temp;
}

foreach (int i in arr2)
{
    Console.Write(i + " ");
}