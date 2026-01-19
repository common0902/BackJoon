int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
int e = int.Parse(Console.ReadLine());

int num = Math.Max((b + d - 1) / d,(c + e - 1) / e);

Console.WriteLine(a - num);