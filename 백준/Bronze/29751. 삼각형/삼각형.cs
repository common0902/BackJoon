string[] input = Console.ReadLine().Split();
        double W = double.Parse(input[0]);
        double H = double.Parse(input[1]);

        double area = W * H / 2;
        Console.WriteLine($"{area:F1}");