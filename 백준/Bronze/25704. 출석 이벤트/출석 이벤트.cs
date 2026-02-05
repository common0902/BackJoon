int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int num = b;

if (a >= 5)
    num = Math.Min(num, b - 500);

if (a >= 10)
    num = Math.Min(num, b * 90 / 100);

if (a >= 15)
    num = Math.Min(num, b - 2000);

if (a >= 20)
    num = Math.Min(num, b * 75 / 100);

if (num < 0)
    num = 0;

Console.WriteLine(num);