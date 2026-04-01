int a = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b = arr[0];
int c = arr[1];
int d = arr[2];

Console.WriteLine(Math.Min(a, b) + Math.Min(a, c) + Math.Min(a, d));