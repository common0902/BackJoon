int[] abc = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
long a = abc[0];
long b = abc[1];
long c = abc[2];

long d = (c * b) / (2 * a);

Console.WriteLine(d);