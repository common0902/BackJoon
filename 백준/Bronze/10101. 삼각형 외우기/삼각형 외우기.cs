int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int sum = a + b + c;

if (a == 60 && b == 60 && c == 60)
{
    Console.WriteLine("Equilateral");
}
else if (sum != 180)
{
    Console.WriteLine("Error");
}
else if (a == b || b == c || a == c)
{
    Console.WriteLine("Isosceles");
}
else
{
    Console.WriteLine("Scalene");
}