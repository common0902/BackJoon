int P = int.Parse(Console.ReadLine());
        for (int i = 0; i < P; i++)
        {
            string[] s = Console.ReadLine().Split();
            string N = s[0];
            double D = double.Parse(s[1]);
            double A = double.Parse(s[2]);
            double B = double.Parse(s[3]);
            double F = double.Parse(s[4]);

            double t = D / (A + B);
            double ans = F * t;

            Console.WriteLine($"{N} {ans:F6}");
        }