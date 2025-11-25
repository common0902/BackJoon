string a = Console.ReadLine();

int b = int.Parse(Console.ReadLine());

int count = 0;

for (int i = 0; i < b; ++i)
{
    string c = Console.ReadLine();

    c += c;

    if(c.Contains(a))
        count++;
}
Console.WriteLine(count);