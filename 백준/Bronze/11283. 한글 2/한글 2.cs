char a = Console.ReadLine()[0];

int b = a - '가';

int c = b / (21 * 28);
int d = (b % (21 * 28)) / 28;
int e = b % 28;

Console.WriteLine(c * 21 * 28 + d * 28 + e + 1);