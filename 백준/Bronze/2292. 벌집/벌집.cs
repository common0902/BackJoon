long a = long.Parse(Console.ReadLine());

int count = 1;
int num = 1;

while (true)
{
    if (a <= num) break;

    num += 6 * count;

    count++;

}
Console.WriteLine(count);