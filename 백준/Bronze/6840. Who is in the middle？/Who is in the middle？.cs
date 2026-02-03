int[] arr = new int[3];
for (int i = 0; i < 3; i++)
    arr[i] = int.Parse(Console.ReadLine());

Array.Sort(arr);
Console.WriteLine(arr[1]);