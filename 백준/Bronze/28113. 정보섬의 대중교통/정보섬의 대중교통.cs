int[] abc = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int a = abc[0];
int b = abc[1];
int c = abc[2];

int bus = b;
int subway;

if (a > c)
    subway = a;
else
    subway = c;

if (bus < subway)
{
    Console.WriteLine("Bus");
}
else if (bus > subway)
{
    Console.WriteLine("Subway");
}
else
{
    Console.WriteLine("Anything");
}
