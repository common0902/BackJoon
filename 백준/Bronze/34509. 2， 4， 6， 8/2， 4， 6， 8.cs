for (int i = 10; i <= 99; i++)
{
    int a = i / 10;
    int b = i % 10;

    if (a == 8 || b == 8) continue;

    int num = b * 10 + a;
    if (num % 4 != 0) continue;

    if ((a + b) % 6 != 0) continue;

    Console.WriteLine(i);
    return;
}