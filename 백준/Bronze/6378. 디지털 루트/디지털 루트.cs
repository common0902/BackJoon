while (true)
{
    string s = Console.ReadLine();
    if (s == "0") break;

    while (s.Length > 1) 
    {
        int num = 0;
        for (int i = 0; i < s.Length; i++)
        {
            num += s[i] - '0';
        }
        s = num.ToString();
    }

    Console.WriteLine(s);
}