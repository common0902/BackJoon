int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int a = ab[0];
int b = ab[1];
int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

for (int i = 0; i < a; i++)
{

    if (arr1[i] < b)
    {
        Console.Write(arr1[i]+" ");
    }
}