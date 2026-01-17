int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = int.Parse(Console.ReadLine());

int num = arr[0] * 3600 + arr[1] * 60 + arr[2] + a;
num %= 86400;

Console.WriteLine($"{num / 3600} {(num % 3600) / 60} {num % 60}");