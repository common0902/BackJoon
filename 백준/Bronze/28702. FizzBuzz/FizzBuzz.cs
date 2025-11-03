    int a = 0;
    for (int i = 3; i > 0; i--)
    {
        string b = Console.ReadLine();
        if (int.TryParse(b, out a))
        {
            a += i;
            goto a;
        }
    }

a:
    if (a % 5 == 0 && a % 3 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (a % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (a % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(a);
    }