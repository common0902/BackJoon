string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]); 
        int B = int.Parse(input[1]); 
        int C = int.Parse(input[2]); 

        int result = 3 * (B / A) * C;

        Console.WriteLine(result);