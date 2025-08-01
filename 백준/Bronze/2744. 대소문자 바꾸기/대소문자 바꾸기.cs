var input = Console.ReadLine();
            string output = string.Empty;

            foreach (var c in input)
            {
                output += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
            }

            Console.WriteLine(output);