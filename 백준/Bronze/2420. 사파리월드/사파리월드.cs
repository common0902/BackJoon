long[] ab = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
Console.WriteLine(Math.Abs(ab[0] - ab[1]));