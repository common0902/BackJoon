int a = int.Parse(Console.ReadLine());
int num = 0;

if (a >= 1_000_000) num = a * 20 / 100;
else if (a >= 500_000) num = a * 15 / 100;
else if (a >= 100_000) num = a * 10 / 100;
else num = a * 5 / 100;

Console.WriteLine($"{num} {a - num}");