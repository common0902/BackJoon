
            while(true)
            {
                long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

                Array.Sort(input);
                long a = input[0];
                long b = input[1];
                long c = input[2];


                if (a == 0 && b == 0 && c == 0)
                {
                    break;
                }
                if (((a * a) + (b * b)) == (c * c))
                {
                    Console.WriteLine("right");
                }
                else
                {
                    Console.WriteLine("wrong");
                }
            }