int a = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine(Math.Min(a, arr[0] / 2 + arr[1]));