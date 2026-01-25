int a = int.Parse(Console.ReadLine());
int num = 0;

for (int i = 0; i < 9; i++)
    num += int.Parse(Console.ReadLine());

Console.WriteLine(a - num);