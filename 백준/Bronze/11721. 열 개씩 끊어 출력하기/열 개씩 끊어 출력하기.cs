string a = Console.ReadLine();
for (int i = 1; i <= a.Length; ++i)
{
    Console.Write(a[i - 1]); 
    if (i % 10 == 0)
    {
        Console.WriteLine();
    }
}