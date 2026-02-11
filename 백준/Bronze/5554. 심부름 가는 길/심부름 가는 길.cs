int num = 0;

for (int i = 0; i < 4; i++)
{
    num += int.Parse(Console.ReadLine());
}

Console.WriteLine(num / 60);
Console.WriteLine(num % 60);