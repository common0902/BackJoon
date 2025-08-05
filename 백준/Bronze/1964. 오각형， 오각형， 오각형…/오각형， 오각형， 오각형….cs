long a = long.Parse(Console.ReadLine());

long num = 0;

for (long i = 0; i <= a; i++)
{
    num += (i * 3 + 1);
}
Console.WriteLine(num % 45678);