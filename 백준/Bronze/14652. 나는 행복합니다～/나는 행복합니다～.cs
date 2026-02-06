int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = arr[1];
int b = arr[2];

Console.WriteLine($"{b / a} {b % a}");