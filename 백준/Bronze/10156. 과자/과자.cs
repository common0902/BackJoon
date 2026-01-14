int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine(Math.Max(0, arr[0] * arr[1] - arr[2]));