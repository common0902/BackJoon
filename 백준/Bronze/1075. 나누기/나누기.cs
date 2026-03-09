int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

a = a - (a % 100);

while (true)
{
    if(a % b == 0) break;

    a++;
}
b = a % 100;
if(b < 10)
    Console.WriteLine("0" + b);
else
    Console.WriteLine(b);