int a = int.Parse(Console.ReadLine());

int c = 8 + (a-1) * 7;

Console.WriteLine($"{2024 + (c / 12 == 3 ?  2: c/12)} {(c % 12 == 0 ? 12 : c % 12)}");