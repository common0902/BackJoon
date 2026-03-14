int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine(Math.Max(arr[0] + arr[2], arr[1]));