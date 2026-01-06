int a = int.Parse(Console.ReadLine());

int count = 0;
int count1 = 0;

while (true)
{
    if (a == count) break;

    count1++;
    if (count1.ToString().Contains("666"))
       count++;
}

Console.WriteLine(count1);