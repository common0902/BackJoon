int a = 0;
for (int i = 0; i < 4; i++)
{
    a += int.Parse(Console.ReadLine());
}

a += 300;

if (a <= 1800)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");