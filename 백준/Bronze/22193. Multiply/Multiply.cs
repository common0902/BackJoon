using System.Numerics;

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

BigInteger a = BigInteger.Parse(Console.ReadLine());
BigInteger b = BigInteger.Parse(Console.ReadLine());

Console.WriteLine(a * b);