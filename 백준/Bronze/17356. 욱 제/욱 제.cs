double[] arr = Array.ConvertAll(Console.ReadLine().Split(),double.Parse);

Console.WriteLine(1.0 / (1.0 + Math.Pow(10.0, (arr[1] - arr[0]) / 400.0)));