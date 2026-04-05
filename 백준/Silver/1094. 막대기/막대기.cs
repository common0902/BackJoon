int a = int.Parse(Console.ReadLine());

int b = 64; 
int c = 0;

while (a > 0)
{
    if (b > a) b /= 2; 
    else
    {
        a -= b;
        c++;
    }
}
Console.WriteLine(c);