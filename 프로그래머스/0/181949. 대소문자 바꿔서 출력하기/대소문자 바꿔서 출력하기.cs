using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        
        for(int i = 0; i < s.Length; ++i)
        {
            Console.Write(s[i] > 90 ? char.ToUpper(s[i]): char.ToLower(s[i]));
        }

    }
}