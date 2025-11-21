int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int num = 0;

foreach (int i in arr)
{
    num += i;
}

Console.WriteLine(num * 5);