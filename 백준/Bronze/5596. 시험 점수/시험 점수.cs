int[] abcd = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

int a = abcd[0];
int b = abcd[1];
int c = abcd[2];
int d = abcd[3];

int[] efgh = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

int e = efgh[0];
int f = efgh[1];
int g = efgh[2];
int h = efgh[3];

int num1 = 0;
int num2 = 0;

num1 = a + b + c + d;
num2 = e + f + g + h;


if (num1 > num2)
{
    Console.WriteLine(num1);
}
else if (num2 > num1)
{
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine(num1);
}