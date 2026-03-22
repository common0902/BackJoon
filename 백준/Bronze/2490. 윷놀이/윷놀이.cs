for (int i = 0; i < 3; i++)
{
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    int count = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] == 0) count++;
    }
    if(count == 1) Console.WriteLine("A");
    else if (count == 2) Console.WriteLine("B");
    else if (count == 3) Console.WriteLine("C");
    else if (count == 4) Console.WriteLine("D");
    else Console.WriteLine("E");
}