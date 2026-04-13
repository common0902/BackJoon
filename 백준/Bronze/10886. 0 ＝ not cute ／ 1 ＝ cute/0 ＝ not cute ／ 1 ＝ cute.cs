int a = int.Parse(Console.ReadLine());

int count = 0;

for (int i = 0; i < a; ++i)
{
    int b = int.Parse(Console.ReadLine());
    if (b == 1) ++count;
    else --count;
}

Console.WriteLine(count > 0 ? "Junhee is cute!" : "Junhee is not cute!");