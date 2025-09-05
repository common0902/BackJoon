int a = int.Parse(Console.ReadLine());
long sum1 = 0; 
long sum2 = 0;
for (int i = 1; i <= a; i++)
{
    sum1 += i;
    sum2 += (long)i * i * i;
}
Console.WriteLine(sum1);
Console.WriteLine(sum1 * sum1);
Console.WriteLine(sum2);