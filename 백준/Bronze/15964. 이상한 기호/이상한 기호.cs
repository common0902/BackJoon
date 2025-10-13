long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
Console.WriteLine((arr[0] + arr[1]) * (arr[0] - arr[1]));