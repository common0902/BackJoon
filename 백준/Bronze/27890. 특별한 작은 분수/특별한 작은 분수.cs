int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int a = ab[0]; 
int b = ab[1]; 

for (int i = 0; i < b; i++)
{
    if (a % 2 == 0)
    {
        a = (a / 2) ^ 6;
    }
    else
    {
        a = (2 * a) ^ 6;
    }
}
Console.WriteLine(a);