int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int num = a * 10;

if (a >= 3)
    num += 20;

if (a == 5)
    num += 50;

if (b > 1000)
    num -= 15;

if (num < 0)
    num = 0;

Console.WriteLine(num);