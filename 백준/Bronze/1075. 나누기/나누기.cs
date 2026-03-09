int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

a = a - (a % 100);

while (true)
{
    if(a % b == 0) break;

    a++;
}

if(a % 100 < 10)
    Console.WriteLine("0" + a % 100);
else
    Console.WriteLine(a % 100);