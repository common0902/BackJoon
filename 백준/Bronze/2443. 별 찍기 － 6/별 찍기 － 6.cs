int a = int.Parse(Console.ReadLine());
int q = a;

for (int i = 0; i < a; i++,q--)
{
    for (int j = 0; j < i ; j++)
    {
        Console.Write(" ");
    }

    for(int j = 0; j < (q - 1)* 2; j++) 
    {
        Console.Write("*");
    }

    Console.WriteLine("*");
}