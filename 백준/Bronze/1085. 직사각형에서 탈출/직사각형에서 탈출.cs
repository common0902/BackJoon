int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine(Math.Min(Math.Min(arr[0], arr[2] - arr[0]),Math.Min(arr[1], arr[3] - arr[1])));