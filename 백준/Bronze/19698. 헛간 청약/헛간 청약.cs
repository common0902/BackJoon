int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int a = arr[0];
        int b = arr[1];
        int c = arr[2];
        int d = arr[3];

        Console.WriteLine(Math.Min(a, (b / d) * (c / d)));