while (true)
{
    int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    int a = ab[0];
    int b = ab[1];
    if (a == 0 && b == 0)
        break;
    Console.WriteLine(a + b);
}