int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int n1 = 0;
int n2 = num2;

while (true)
{
    n1 = num2 % 10;
    Console.WriteLine(num1 * n1);
    num2 = num2 / 10;

    if (num2 <= 0) break;
}
Console.WriteLine(num1 * n2);