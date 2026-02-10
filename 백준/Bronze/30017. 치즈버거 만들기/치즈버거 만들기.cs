int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = arr[0];
int b = arr[1];

Console.WriteLine(Math.Min(b, a - 1) * 2 + 1);