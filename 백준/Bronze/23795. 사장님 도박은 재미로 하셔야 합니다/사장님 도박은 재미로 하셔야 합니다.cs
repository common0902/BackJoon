int num = 0;
while (true)
{
    int a = int.Parse(Console.ReadLine());

    if (a == -1) break;

    num += a;
}
Console.WriteLine(num);