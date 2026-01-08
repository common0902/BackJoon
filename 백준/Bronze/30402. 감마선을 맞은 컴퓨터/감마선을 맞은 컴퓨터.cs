for (int i = 0; i < 15; i++)
{
    string[] arr = Console.ReadLine().Split();

    foreach (string j in arr)
    {
        if (j == "w")
        {
            Console.WriteLine("chunbae");
            return;
        }
        else if (j == "b")
        {
            Console.WriteLine("nabi");
            return;
        }
        else if (j == "g")
        {
            Console.WriteLine("yeongcheol");
            return;
        }
    }
}