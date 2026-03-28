int a = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Console.WriteLine((arr[0] + arr[1] + arr[2] >= a || a <= 240) ? "high speed rail" : "flight");